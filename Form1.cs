using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus;
using System.Runtime.CompilerServices;
namespace C__Winform_报警实时监控
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            //初始化连接参数
            InitParameter();
        }
        /// <summary>
        /// 初始化串口参数
        /// </summary>
        public void InitParameter()
        {
            //获取本机所有端口号
            this.comboBox_SerialPort.DataSource = SerialPort.GetPortNames();
            //获取波特率默认第一项9600
            this.comboBox_Bauder.SelectedIndex = 0;
            //获取校验位，从Parity parity获取枚举并转换
            this.comboBox_Check.DataSource = Enum.GetValues(typeof(Parity));
            //默认数据位8位
            this.textBox_data.Text = "8";
            //停止位
            this.ComboBox_Stop.DataSource = Enum.GetValues(typeof(StopBits));
            //默认起始地址0
            this.textBox_Start.Text = "0";
            //地址长度
            this.textBox_length.Text = "10";
        }

        private static SerialPort _serialPort; //串口类
        private static CancellationTokenSource _cancellationTokenSource;
        private static ModbusSerialMaster _master;//主站
        Task listenTask;//监听任务
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
             // 配置串口参数
            _serialPort = new SerialPort
            {
                PortName = this.comboBox_SerialPort.Text,        // 根据实际串口名称修改
                BaudRate = 9600,          // 波特率
                DataBits = 8,             // 数据位
                StopBits = StopBits.One,  // 停止位
                Parity = Parity.None      // 校验位
            };
            try
            {
                // 打开串口
                _serialPort.Open();
                MessageBox.Show($"串口 {_serialPort.PortName} 连接成功");
                //更新设备状态
                this.button_device.BackColor = Color.Green;
                this.button_device.Text = $"设备已连接";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"串口 {_serialPort.PortName} 无法打开，或已经被占用");
            }
            finally
            {
               
            }

        }
        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            // 关闭串口
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show($"设备已断开");
                //更新设备状态
                this.button_device.BackColor = Color.Red;
                this.button_device.Text = $"设备已断开";
            }
            else
            {
                MessageBox.Show("请确实已连接设备");
            }

        }

        /// <summary>
        ///开启监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_observe_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen) {
                MessageBox.Show("监听已开启");
                this.button_observe.BackColor = Color.Green;
                this.button_observe.Text = $"正在监听{_serialPort.PortName}";

                _cancellationTokenSource = new CancellationTokenSource();
                _master = ModbusSerialMaster.CreateRtu( _serialPort ); //创建modbusrtu主站
                // 启动数据监听任务
                 listenTask = StartListening(_master, _cancellationTokenSource.Token);
            }
            else
            {
                MessageBox.Show("请确实已连接设备");
                return;
            }
        }
        /// <summary>
        /// 监听任务
        /// </summary>
        /// <param name="master"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private async Task StartListening(IModbusSerialMaster master, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {           
                    // 读取线圈状态示例 (从站地址1, 起始地址0, 读取10个线圈)
                    bool[] coils = await master.ReadCoilsAsync(1, 0, 10);
                    String str = $"[{DateTime.Now:HH:mm:ss}] 从站1 线圈状态: [{string.Join(", ", coils)}]";
                    PrintLog(str);
                    UpdateButton(coils);
                    // 等待1秒后继续
                    await Task.Delay(1000, token);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"读取数据时发生错误: {ex.Message}");
                    await Task.Delay(5000, token); // 出错后等待5秒再重试
                }
            }
        }
        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="str"></param>
        private void PrintLog(String str)
        {
            //打印日志
            this.richTextBox1.Invoke(new Action(() =>
            {
                this.richTextBox1.AppendText(str + "\n");
            }));
        }
        /// <summary>
        /// 停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void button_disobserve_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            this.button_observe.BackColor = Color.Red;
            this.button_observe.Text = "开始监听";
        }
        private void UpdateButton(bool[] coils)
        {
            int i = 0;
            foreach (var ele in this.groupBox3.Controls) {
                Button btn = (Button)ele;
                if (coils[i])
                {
                    
                    btn.BackColor = Color.Green;
                    btn.Text = coils[i].ToString();
                }
                else {
                    
                    btn.BackColor = Color.Red;
                    btn.Text = coils[i].ToString();
                }
                i++;
            }

        }
    }

}
