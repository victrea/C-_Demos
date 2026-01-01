# C# Winform 报警实时监控

项目概述
- 基于 WinForms 的串口 Modbus RTU 实时报警/状态监控客户端。
- 目标框架：`.NET Framework 4.7.2`，C# 版本：`7.3`。
- 核心实现文件：`Form1.cs`（窗体与业务逻辑）、`Program.cs`（程序入口）、`Properties\AssemblyInfo.cs`（程序集信息）。

主要功能
- 串口管理
  - 列出本机可用串口（通过 `SerialPort.GetPortNames()`）。
  - 支持配置波特率、数据位、校验位、停止位等（界面控件可选）。
- 设备连接／断开
  - 打开并关闭串口，连接成功或断开后更新 UI 状态（设备指示按钮颜色和文本）。
- Modbus RTU 主站访问
  - 使用 Modbus RTU 主站（`ModbusSerialMaster.CreateRtu`）按轮询方式读取从站线圈状态（默认从站地址 1、起始地址 0、长度 10）。
- 实时监听与显示
  - 异步监听任务（使用 `async/await` 与 `CancellationTokenSource`）周期读取数据并写入日志（`richTextBox1`）。
  - 将读取到的线圈状态映射到 UI 上的一组按钮，使用颜色（绿色/红色）表示开/关。
- 日志与错误处理
  - 在界面打印时间戳日志（读取结果或异常信息），读取异常弹窗提示并在错误时等待后重试。

关键类与方法（快速索引）
- `form`（窗体类，定义在 `Form1.cs`）
  - `InitParameter()`：初始化串口相关下拉/输入控件的默认值。
  - `button_connect_Click`：建立并打开串口连接，更新设备状态。
  - `button_disconnect_Click`：关闭串口连接。
  - `button_observe_Click`：创建 Modbus 主站并启动监听任务。
  - `StartListening(IModbusSerialMaster master, CancellationToken token)`：异步循环读取线圈并调用 `PrintLog` / `UpdateButton`。
  - `button_disobserve_Click`：取消监听任务（调用 `CancellationTokenSource.Cancel()`）。
  - `UpdateButton(bool[] coils)`：根据线圈数组更新一组 Button 的颜色与文本。
- 程序入口：`Program.cs` 中的 `Main()`，启动窗体 `form`。

依赖与准备
- 需要 Modbus 客户端库（例如 `NModbus` 或 `NModbus4`）。在 Visual Studio 中通过 __Tools > NuGet Package Manager > Manage NuGet Packages for Solution__ 安装对应包。
- 串口设备：真实 Modbus RTU 设备或使用 Modbus 模拟器（如 Modbus Poll/ModbusPal）进行测试。
- 在 Visual Studio 中确认目标框架为 `.NET Framework 4.7.2`：打开项目属性检查 __Target framework__。

快速使用指南
1. 连接硬件或启动 Modbus 从站模拟器并设置从站地址、线圈数据。
2. 启动程序（在 Visual Studio 中使用 __Debug > Start Debugging__ 或运行生成的可执行文件）。
3. 在界面选择串口并配置参数（若界面提供项则选择相应值）。
4. 点击“连接”按钮建立串口连接，确认设备指示变为已连接。
5. 点击“开始监听”/“监听”按钮启动 Modbus 轮询；查看日志与按钮状态变化。
6. 点击“停止监听”或“断开连接”结束监听并关闭串口。

调试与注意事项
- 如果串口无法打开，请确认端口被其它程序占用或权限问题。
- 确保波特率、校验位、数据位、停止位等与从站设备一致。
- 异常读取时程序会弹窗提示并在 5 秒后重试；可在调试模式下检查异常堆栈以定位问题。
- UI 更新在异步任务中使用 `Invoke` 调用以避免跨线程操作异常。

文件列表（主要）
- `Form1.cs` — 窗体与 Modbus 逻辑实现。
- `Program.cs` — 应用入口。
- `Properties\AssemblyInfo.cs` — 程序集元数据。

许可与扩展建议
- 当前实现为演示/工具类项目，可按需增加：
  - 支持配置从站 ID、起始地址、读取长度的 UI 输入。
  - 将日志保存到文件（按天或大小切分）。
  - 增加重连策略与更细粒度的异常处理。
  - 支持 TCP Modbus（`ModbusTcpMaster`）以兼容网络设备。

作者备注
- 本说明基于当前代码实现（`Form1.cs`）撰写，若后续代码结构或功能变更，请更新此 `README.md` 以保持一致。
