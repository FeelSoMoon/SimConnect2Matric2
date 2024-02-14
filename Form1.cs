using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.FlightSimulator.SimConnect;
using Matric.Integration;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Eventing.Reader;
using static Matric.Integration.ServerVariable;
using System.Timers;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;

public enum SimConnectDataTypes
{
    number,
    feet,
    radians,
    degrees,
    knots,
    inHg,
    millibars,
    mach
}
public enum MatricDataTypes
{
    output_number,
    output_decimal,
    output_string,
    output_heading,
    output_frequency,
    output_transponder,
    button
}

public enum TransponderState
{
    Off,
    Standby,
    Test,
    On,
    Alt,
    Ground
}

enum DEFINITIONS
{
    SimConnectData,
}

enum DATA_REQUESTS
{
    REQUEST_1,
};

enum EVENT_ID
{
    TEXT,
};

enum SIMCONNECT_EXCEPTION
{
    SIMCONNECT_EXCEPTION_NONE,
    SIMCONNECT_EXCEPTION_ERROR,
    SIMCONNECT_EXCEPTION_SIZE_MISMATCH,
    SIMCONNECT_EXCEPTION_UNRECOGNIZED_ID,
    SIMCONNECT_EXCEPTION_UNOPENED,
    SIMCONNECT_EXCEPTION_VERSION_MISMATCH,
    SIMCONNECT_EXCEPTION_TOO_MANY_GROUPS,
    SIMCONNECT_EXCEPTION_NAME_UNRECOGNIZED,
    SIMCONNECT_EXCEPTION_TOO_MANY_EVENT_NAMES,
    SIMCONNECT_EXCEPTION_EVENT_ID_DUPLICATE,
    SIMCONNECT_EXCEPTION_TOO_MANY_MAPS,
    SIMCONNECT_EXCEPTION_TOO_MANY_OBJECTS,
    SIMCONNECT_EXCEPTION_TOO_MANY_REQUESTS,
    SIMCONNECT_EXCEPTION_WEATHER_INVALID_PORT,
    SIMCONNECT_EXCEPTION_WEATHER_INVALID_METAR,
    SIMCONNECT_EXCEPTION_WEATHER_UNABLE_TO_GET_OBSERVATION,
    SIMCONNECT_EXCEPTION_WEATHER_UNABLE_TO_CREATE_STATION,
    SIMCONNECT_EXCEPTION_WEATHER_UNABLE_TO_REMOVE_STATION,
    SIMCONNECT_EXCEPTION_INVALID_DATA_TYPE,
    SIMCONNECT_EXCEPTION_INVALID_DATA_SIZE,
    SIMCONNECT_EXCEPTION_DATA_ERROR,
    SIMCONNECT_EXCEPTION_INVALID_ARRAY,
    SIMCONNECT_EXCEPTION_CREATE_OBJECT_FAILED,
    SIMCONNECT_EXCEPTION_LOAD_FLIGHTPLAN_FAILED,
    SIMCONNECT_EXCEPTION_OPERATION_INVALID_FOR_OBJECT_TYPE,
    SIMCONNECT_EXCEPTION_ILLEGAL_OPERATION,
    SIMCONNECT_EXCEPTION_ALREADY_SUBSCRIBED,
    SIMCONNECT_EXCEPTION_INVALID_ENUM,
    SIMCONNECT_EXCEPTION_DEFINITION_ERROR,
    SIMCONNECT_EXCEPTION_DUPLICATE_ID,
    SIMCONNECT_EXCEPTION_DATUM_ID,
    SIMCONNECT_EXCEPTION_OUT_OF_BOUNDS,
    SIMCONNECT_EXCEPTION_ALREADY_CREATED,
    SIMCONNECT_EXCEPTION_OBJECT_OUTSIDE_REALITY_BUBBLE,
    SIMCONNECT_EXCEPTION_OBJECT_CONTAINER,
    SIMCONNECT_EXCEPTION_OBJECT_AI,
    SIMCONNECT_EXCEPTION_OBJECT_ATC,
    SIMCONNECT_EXCEPTION_OBJECT_SCHEDULE,
    SIMCONNECT_EXCEPTION_JETWAY_DATA,
    SIMCONNECT_EXCEPTION_ACTION_NOT_FOUND,
    SIMCONNECT_EXCEPTION_NOT_AN_ACTION,
    SIMCONNECT_EXCEPTION_INCORRECT_ACTION_PARAMS,
    SIMCONNECT_EXCEPTION_GET_INPUT_EVENT_FAILED,
    SIMCONNECT_EXCEPTION_SET_INPUT_EVENT_FAILED,
};


[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct SimConnectData
{
    //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    //LOTS OF THINGS!
    public double d0;
    public double d1; public double d2; public double d3; public double d4; public double d5; public double d6; public double d7; public double d8; public double d9; public double d10;
    public double d11; public double d12; public double d13; public double d14; public double d15; public double d16; public double d17; public double d18; public double d19; public double d20;
    public double d21; public double d22; public double d23; public double d24; public double d25; public double d26; public double d27; public double d28; public double d29; public double d30;
    public double d31; public double d32; public double d33; public double d34; public double d35; public double d36; public double d37; public double d38; public double d39; public double d40;
    public double d41; public double d42; public double d43; public double d44; public double d45; public double d46; public double d47; public double d48; public double d49; public double d50;
    public double d51; public double d52; public double d53; public double d54; public double d55; public double d56; public double d57; public double d58; public double d59; public double d60;
    public double d61; public double d62; public double d63; public double d64; public double d65; public double d66; public double d67; public double d68; public double d69; public double d70;
    public double d71; public double d72; public double d73; public double d74; public double d75; public double d76; public double d77; public double d78; public double d79; public double d80;
    public double d81; public double d82; public double d83; public double d84; public double d85; public double d86; public double d87; public double d88; public double d89; public double d90;
    public double d91; public double d92; public double d93; public double d94; public double d95; public double d96; public double d97; public double d98; public double d99; public double d100;
    public double d101; public double d102; public double d103; public double d104; public double d105; public double d106; public double d107; public double d108; public double d109; public double d110;
    public double d111; public double d112; public double d113; public double d114; public double d115; public double d116; public double d117; public double d118; public double d119; public double d120;
    public double d121; public double d122; public double d123; public double d124; public double d125; public double d126; public double d127; public double d128; public double d129; public double d130;
    public double d131; public double d132; public double d133; public double d134; public double d135; public double d136; public double d137; public double d138; public double d139; public double d140;
    public double d141; public double d142; public double d143; public double d144; public double d145; public double d146; public double d147; public double d148; public double d149; public double d150;
    public double d151; public double d152; public double d153; public double d154; public double d155; public double d156; public double d157; public double d158; public double d159; public double d160;
    public double d161; public double d162; public double d163; public double d164; public double d165; public double d166; public double d167; public double d168; public double d169; public double d170;
    public double d171; public double d172; public double d173; public double d174; public double d175; public double d176; public double d177; public double d178; public double d179; public double d180;
    public double d181; public double d182; public double d183; public double d184; public double d185; public double d186; public double d187; public double d188; public double d189; public double d190;
    public double d191; public double d192; public double d193; public double d194; public double d195; public double d196; public double d197; public double d198; public double d199; public double d200;
}



namespace SimConnect2Matric2
{
    public partial class Form1 : Form
    {
        public DataTable myDataTable = new DataTable { TableName = "SimConnectDataTable" };

        // SimConnect object
        SimConnect simconnect = null;

        // User-defined win32 event
        const int WM_USER_SIMCONNECT = 0x0402;
        const int MAX_LOG_SIZE = 100;

        readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "debug.log");
        readonly string dataTablePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataTable.xml");

        public Boolean SimConnectStatus = false;
        public Boolean RunSimConnect = false;

        public Boolean MatricStatus = false;
        public Boolean RunMatric = false;

        //const int MATRIC_PIN = 1234;
        const string MATRIC_APP_NAME = "SimConnect2Matric 2";
        const string MATRIC_DECK_ID = "";
        const int MATRIC_API_PORT = 50300;
        public static string CLIENT_ID;
        static System.Timers.Timer timer;

        private readonly object lockCheck = new object();
        private bool CheckingForApps = false;

        //define which SimVars need to be handled uniquely.
        public string[] uniqueFormats = { "AUTOPILOT VERTICAL HOLD VAR", "TRANSPONDER STATE"};

        static Matric.Integration.Matric matric;

        Dictionary<int, Dictionary<string, string>> DataDictionary = new Dictionary<int, Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
            ManageLogFile();
            InitializeDataGridView();
            InitializeDataTable();
            BindDataTableToDataGridView();

            if (!CheckingForApps)
            {
                CheckForRunningApps();
            }

            //anchoring ui elements
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
            textLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            this.FormClosing += Form1_FormClosing;
        }

        private void MatricSetStatus(int status)
        {
            Color color;
            switch (status)
            {
                case 2:
                    color = Color.Yellow;
                    MatricStatus = true;
                    
                    break;
                case 3:
                    color = Color.Green;
                    MatricStatus = true;
                    break;
                default:
                    color = Color.Red;
                    MatricStatus = false;
                    break;
            }
            if (statusStrip1.InvokeRequired)
            {
                // Call the same method on the UI thread
                statusStrip1.Invoke(new Action(() => MatricSetStatus(status)));
            }else{
                // Update label color on the UI thread
                toolStripProgressBarMatric.BackColor = color;
            }
        }


        private void SimConnectSetStatus(int status)
        {
            Color color;
            switch (status)
            {
                case 2:
                    color = Color.Yellow;
                    SimConnectStatus = true;
                    break;
                case 3:
                    color = Color.Green;
                    SimConnectStatus = true;
                    break;
                default:
                    color = Color.Red;
                    SimConnectStatus = false;
                    break;
            }
            if (statusStrip1.InvokeRequired)
            {
                // Call the same method on the UI thread
                statusStrip1.Invoke(new Action(() => SimConnectSetStatus(status)));
            }
            else
            {
                // Update label color on the UI thread
                toolStripProgressBarSimConnect.BackColor = color;
            }
        }

        private void InitMatric()
        {
            matric = null;
            WriteLog("Initialising Matric");
            try {
                matric = matric ?? new Matric.Integration.Matric(MATRIC_APP_NAME, "", MATRIC_API_PORT);
            }
            catch (Exception ex)
            {
                WriteLog("Matric: " + ex.Message);
            }
            if(matric!=null)
            { 
                matric.PIN = "";
                matric.OnError += Matric_OnError;
                matric.OnConnectedClientsReceived += Matric_OnConnectedClientsReceived;
                matric.OnControlInteraction += Matric_OnControlInteraction;
                matric.OnVariablesChanged += Matric_OnVariablesChanged;

                MatricGetClients();
            }
        }

        private void Matric_OnVariablesChanged(object sender, ServerVariablesChangedEventArgs data)
        {
            //DO NOTHING
        }

        private void Matric_OnError(Exception ex)
        {
            WriteLog($"Matric Error: {ex}");
            MatricStatus = false;
            MatricSetStatus(1);
        }

        private void Matric_OnControlInteraction(object sender, object data)
        {
            //DO NOTHING
        }

        private void Matric_OnConnectedClientsReceived(object source, List<ClientInfo> clients)
        {
            MatricUpdateClientsList(clients);
        }

        public void MatricUpdateClientsList(List<ClientInfo> connectedClients)
        {
            if (connectedClients.Count == 0)
            {
                CLIENT_ID = null;
                MatricStatus = false;
                MatricSetStatus(2);
                WriteLog("Matric: No connected devices found");
            }else{
                foreach (ClientInfo client in connectedClients)
                {
                   WriteLog($@"Matric Found devices: {client.Name}");
                }
                CLIENT_ID = connectedClients[0].Id;
                MatricStatus = true;
                MatricSetStatus(3);
            }
        }

        private void MatricTest()
        {
            ServerVariable vString = new ServerVariable()
            {
                Name = "demo_string",
                VariableType = ServerVariable.ServerVariableType.STRING,
                Value = "Initial string"
            };

            List<ServerVariable> variables = new List<ServerVariable>() {
                vString
            };

            matric.SetVariables(variables);
        }

        private void MatricGetClients()
        {
            WriteLog("Matric: Getting Clients");
            matric?.GetConnectedClients();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteLog("User exit, disposing of connection");
            // Perform cleanup tasks or execute a function here
            // This code will run when the form is closing

            if (simconnect != null)
            {
                //simconnect.Dispose();
            }
        }

        private void ManageLogFile()
        {
            CheckDebugExists();
            LoadLogFile();
        }
        private void LoadLogFile()
        {
            try{
                int NumberOfLinesToShow = 28;
                var lines = File.ReadLines(logFilePath);
                var lastLines = lines.Skip(Math.Max(0, lines.Count() - NumberOfLinesToShow));
                textLog.Text= string.Join(Environment.NewLine, lastLines);
                //ScrollTextBoxToBottom(textLog);
            }
            catch (Exception ex)
            {
                WriteLog($"EXCEPTION whilst loading log: {ex.Message}");
                // Handle exceptions, e.g., display an error message
               // MessageBox.Show($"Error loading log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteLog(string newline)
        {
            if (textLog.InvokeRequired)
            {
                // Call the same method on the UI thread
                textLog.Invoke(new Action(() => WriteLog(newline)));
            }
            else
            {
                string currentTimeFormatted = DateTime.Now.ToString("HH:mm:ss");
                FileInfo fileInfo = new FileInfo(logFilePath);
                if (fileInfo.Exists)
                {
                    long fileSizeInBytes = fileInfo.Length;
                    double fileSizeInKB = fileSizeInBytes / 1024.0; // Bytes to Kilobytes

                    try
                    {
                        string[] lines = File.ReadAllLines(logFilePath);
                        if (fileSizeInKB > MAX_LOG_SIZE)
                        {
                            lines = lines.Skip(50).ToArray();
                        }
                        lines = lines.Concat(new[] { currentTimeFormatted + " - " + newline }).ToArray();
                        Console.WriteLine(currentTimeFormatted + " - " + newline);
                        try
                        {
                            File.WriteAllLines(logFilePath, lines);

                        }
                        catch (IOException ex)
                        {
                            // Handle the case where the file is in use
                            Console.WriteLine($"Error writing to the file: {ex.Message}");
                        }
                        LoadLogFile();
                    }
                    catch(Exception ex) {
                        WriteLog("Log file current not accessible");
                    }

                    
                }
            }
            
        }

        private Boolean CheckDebugExists()
        {
            if (File.Exists(logFilePath) == false)
            {
                FileStream logFile = File.Create(logFilePath);
                logFile.Close();
                WriteLog("Log File Created");
            }
            return File.Exists(logFilePath);
        }

        static void ScrollTextBoxToBottom(System.Windows.Forms.TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void InitializeDataGridView()
        {
            WriteLog("Initialising DataGridView");
            // Create a DataGridViewComboBoxColumn for the enum field
            DataGridViewTextBoxColumn textDataItem = new DataGridViewTextBoxColumn
            {
                HeaderText = "Data Item",
                DataPropertyName = "DataItem",
                Width = 320
            };

            DataGridViewComboBoxColumn comboBoxDataType = new DataGridViewComboBoxColumn
            {
                HeaderText = "Data Type",
                DataPropertyName = "DataType",
                DataSource = Enum.GetValues(typeof(SimConnectDataTypes)),
                Width = 75
            };

            DataGridViewComboBoxColumn comboBoxMatricType = new DataGridViewComboBoxColumn
            {
                HeaderText = "Matric Type",
                DataPropertyName = "MatricType",
                DataSource = Enum.GetValues(typeof(MatricDataTypes)),
                Width = 120
            };

            DataGridViewTextBoxColumn textValue = new DataGridViewTextBoxColumn
            {
                HeaderText = "Value",
                DataPropertyName = "Value",
                Width = 120
            };

            // Add the DataGridViewComboBoxColumn to the DataGridView
            dataGridView1.Columns.Add(textDataItem);
            dataGridView1.Columns.Add(comboBoxDataType);
            dataGridView1.Columns.Add(comboBoxMatricType);
            dataGridView1.Columns.Add(textValue);

            dataGridView1.AutoGenerateColumns = false;

            // Subscribe to the DataError event
            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void InitializeDataTable()
        {
            WriteLog("Initialising DataTable");
            myDataTable.Columns.Add("DataItem", typeof(string));
            myDataTable.Columns.Add("DataType", typeof(SimConnectDataTypes));
            myDataTable.Columns.Add("MatricType", typeof(MatricDataTypes));
            myDataTable.Columns.Add("Value", typeof(string));

            myDataTable.RowDeleted += OnRowDeleted;
            //myDataTable.RowChanged += OnRowDeleted;
        }

        private void OnRowDeleted(object sender, DataRowChangeEventArgs e)
        {
            //SaveXML();
            InitDataRequest();
        }

        private void BindDataTableToDataGridView()
        {
            WriteLog("Binding DataTable to DataGridView");
            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = myDataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(baseDirectory);
            if (DataFileExist())
            {
                WriteLog("DataTable exists, will attempt to load XML.");
                LoadXML();
            }
        }
        private void CheckForRunningApps()
        {
            CheckingForApps = true;

            string matricName = "MatricServer"; // Replace with the actual process name
            string msfsName = "FlightSimulator"; // Replace with the actual process name

            WriteLog("Checking for required applications");
            int seconds = 60;
            timer = new System.Timers.Timer(1000 * seconds); // Interval is in milliseconds, e.g., 1000 ms = 1 second

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = false; // Set to true if you want the timer to repeat

            if (IsProcessRunning(matricName) && !MatricStatus)
            {
                WriteLog($"Found {matricName}");
                RunMatric = true;
                InitMatric();
            }
            else if (!IsProcessRunning(matricName))
            {
                WriteLog($"{matricName} is not running");
            }

            if (IsProcessRunning(msfsName) && !SimConnectStatus)
            {
                WriteLog($"Found {msfsName}");
                RunSimConnect = true;
                InitDataRequest();
            }
            else if (!IsProcessRunning(msfsName))
            {
                WriteLog($"{msfsName} is not running");
            }

            if (!MatricStatus || !SimConnectStatus)
            {
                timer.Start();
                WriteLog($"Will check again for required apps in {seconds} seconds");
            }
            if (MatricStatus && SimConnectStatus)
            {
                timer.Stop();
                CheckingForApps = false;
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            // Perform UI-related operations on the UI thread using Invoke
            Invoke(new Action(() =>
            {
                CheckForRunningApps();
            }));
        }

        private bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        private void SaveXML()
        {
            foreach (DataRow row in myDataTable.Rows)
            {
                row["Value"] = string.Empty;
            }
            myDataTable.AcceptChanges();
            myDataTable.WriteXml(dataTablePath, XmlWriteMode.WriteSchema, true);
        }

        private void LoadXML()
        {
            try
            {
                // Load the XML file into a new DataTable
                DataTable newDataTable = new DataTable();
                newDataTable.ReadXml(dataTablePath);

                // Clear the existing rows in the current DataTable
                myDataTable.Rows.Clear();

                // Add the rows from the new DataTable to the current DataTable
                foreach (DataRow row in newDataTable.Rows)
                {
                    myDataTable.Rows.Add(row.ItemArray);
                }

                // Refresh the DataGridView to reflect the changes
                dataGridView1.Refresh();
                WriteLog("DataTable loaded");
            }
            catch (Exception ex)
            {
                WriteLog($"EXCEPTION loading DataTable: {ex.Message}");
                // Handle exceptions, e.g., display an error message
                MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean DataFileExist()
        {
            return File.Exists(dataTablePath);
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the data error
            //MessageBox.Show($"Data error in row {e.RowIndex}, column {e.ColumnIndex}: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, you can cancel the DataGridView's default behavior
            e.ThrowException = false;
        }

        public string EnumToString(int enumIndex, Type enumType)
        {
            // Check if the provided type is an enum
            if (!enumType.IsEnum)
            {
                Console.WriteLine("Type provided is not an enum");
            }

            string[] enumNames = Enum.GetNames(enumType);

            // Check if the provided index is within the valid range
            if (enumIndex < 0 || enumIndex >= enumNames.Length)
            {
                Console.WriteLine("Enum index is out of range");
            }

            string enumString = enumNames[enumIndex];

            return enumString;
        }

        public string ObjToDataType(object myObj)
        {
            SimConnectDataTypes[] enumValues = (SimConnectDataTypes[])Enum.GetValues(typeof(SimConnectDataTypes));
            if (int.TryParse(myObj.ToString(), out int intValue))
            {
                SimConnectDataTypes selectedEnumValue = enumValues[intValue];
                return selectedEnumValue.ToString();
            }
            return string.Empty;
        }

        public string SimConnectExceptionToString(object myObj)
        {
            SIMCONNECT_EXCEPTION[] enumValues = (SIMCONNECT_EXCEPTION[])Enum.GetValues(typeof(SIMCONNECT_EXCEPTION));
            if (int.TryParse(myObj.ToString(), out int intValue))
            {
                SIMCONNECT_EXCEPTION selectedEnumValue = enumValues[intValue];
                return selectedEnumValue.ToString();
            }
            return string.Empty;
        }

        private void InitDataRequest()
        {
            WriteLog("Initialising DataRequest");

            try
            {
                simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
            }
            catch (COMException ex)
            {
                if(ex.ErrorCode == -2147467259)
                {
                    WriteLog("MSFS isn't running, or it's running and the SDK/SimConnect isn't installed.");
                    return;
                }
                else
                {
                    WriteLog("EXCEPTION SimConnect " + ex);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (simconnect != null)
                {
                    SimConnectStatus = true;
                    SimConnectSetStatus(3);
                    WriteLog("SimConnect DataRequest active");
                    // listen to connect and quit msgs
                    simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
                    simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);

                    // listen to exceptions
                    simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(Simconnect_OnRecvException);

                    DataDictionary.Clear();
                    int i = 0;

                    foreach (DataRow row in myDataTable.Rows)
                    {
                        simconnect.AddToDataDefinition(DEFINITIONS.SimConnectData, row["DataItem"].ToString(), EnumToString(Convert.ToInt32(row["DataType"]),typeof(SimConnectDataTypes)), SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                        DataDictionary[i] = new Dictionary<string, string> { { row["DataItem"].ToString(), "" } };
                        i++;
                    }
                    
                    // define a data structure
                    //simconnect.AddToDataDefinition(DEFINITIONS.SimConnectData, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                    // IMPORTANT: register it with the simconnect managed wrapper marshaller
                    // if you skip this step, you will only receive a uint in the .dwData field.
                    simconnect.RegisterDataDefineStruct<SimConnectData>(DEFINITIONS.SimConnectData);

                    // catch a simobject data request
                    simconnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(Simconnect_OnRecvSimobjectData);

                    // Request data at the specified period.
                    simconnect.RequestDataOnSimObject(DATA_REQUESTS.REQUEST_1
                    , DEFINITIONS.SimConnectData
                    , SimConnect.SIMCONNECT_OBJECT_ID_USER
                    , SIMCONNECT_PERIOD.VISUAL_FRAME   //SIM_FRAME   VISUAL_FRAME    SECOND
                    , SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT
                    , 0
                    , 0
                    , 0);
                }
                else
                {
                    WriteLog("SimConnect is not running.");
                }

            }
            catch (COMException ex)
            {
                WriteLog(ex.Message);
            }
        }

        
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                try
                {
                    simconnect?.ReceiveMessage();
                } catch (Exception ex) {
                    WriteLog("MSFS was closed unexpectedly");
                    SimConnectSetStatus(1);
                    if (!CheckingForApps) {
                        CheckForRunningApps();
                    }
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            WriteLog("SimConnect connection established");
            SimConnectStatus = true;
            SimConnectSetStatus(3);
        }

        void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            WriteLog("SimConnect connection lost");
            SimConnectStatus = false;
            SimConnectSetStatus(1);
        }

        void Simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {

            WriteLog("SimConnect recieved an error: " + SimConnectExceptionToString(data.dwException));
            SimConnectStatus = false;
            SimConnectSetStatus(2);
            InitDataRequest();
        }

        void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    SimConnectData s1 = (SimConnectData)data.dwData[0];

                    if (RunSimConnect) { 
                    int i = 0;

                        DataDictionary.Clear();

                        foreach (DataRow row in myDataTable.Rows)
                        {

                            string fieldName = $"d{i}";
                            var fieldValue = typeof(SimConnectData).GetField(fieldName)?.GetValue(s1);
                            string formattedData = FormatData(fieldValue, row);
                            string storedValue = row["Value"]?.ToString()?.Trim();

                            if (fieldValue != null)
                            {
                                if (formattedData != storedValue)
                                {
                                    //removed from WriteLog because certain vars can spam the log
                                    //WriteLog(row["DataItem"].ToString() + " changed from " + row["Value"].ToString() + " to " + formattedData);
                                    Console.WriteLine($"{row["DataItem"]} changed from {row["Value"]} to {formattedData} | pre formatted {fieldValue}");
                                    row["Value"] = formattedData;
                                    DataDictionary[i] = new Dictionary<string, string> { { row["DataItem"].ToString(), formattedData } };
                                }
                            }
                            i++;
                        }

                        //check if we're sending this to Matric
                        if(MatricStatus && RunMatric)
                        {
                            List<ServerVariable> variables = new List<ServerVariable>() {
                            };

                            // Iterate through the outer dictionary
                            foreach (KeyValuePair<int, Dictionary<string, string>> outerKvp in DataDictionary)
                            {
                                // Iterate through the inner dictionary
                                foreach (KeyValuePair<string, string> innerKvp in outerKvp.Value)
                                {
                                    //search datatable, check if this has the output type of "button"
                                    DataRow[] searchResults = myDataTable.Select($"DataItem = '{innerKvp.Key}'");
                                    string matricTypeValue = string.Empty;
                                    ServerVariableType VarType;
                                    if (searchResults.Length > 0)
                                    {
                                        matricTypeValue=EnumToString(searchResults[0].Field<int>("MatricType"), typeof(MatricDataTypes));
                                    }

                                    VarType = (matricTypeValue == "button") ? ServerVariable.ServerVariableType.BOOL : ServerVariable.ServerVariableType.STRING;

                                    ServerVariable vString = new ServerVariable()
                                    {
                                        Name = innerKvp.Key,
                                        VariableType = VarType,
                                        Value = innerKvp.Value
                                    };
                                    variables.Add(vString);
                                }
                            }
                            if (variables.Count > 0) { 
                                matric?.SetVariables(variables);
                            }
                        }
                        //for debug only
                        //DisplayDataDictionary();
                    }
                    break;

                default:
                    WriteLog("SimConnect Unknown request ID: " + data.dwRequestID);
                    break;
            }
        }

        private void DisplayDataDictionary()
        {
            foreach (var kvp in DataDictionary)
            {
                int outerKey = kvp.Key;
                Dictionary<string, string> innerDictionary = kvp.Value;

                //Console.WriteLine($"Outer Key: {outerKey}");

                foreach (var innerKvp in innerDictionary)
                {
                    string innerKey = innerKvp.Key;
                    string innerValue = innerKvp.Value;

                    Console.WriteLine($"{innerKey}: {innerValue}");
                }
            }
        }

        string FormatData(object input,DataRow tableRow)
        {
            string formatType = EnumToString(Convert.ToInt32(tableRow["MatricType"]),typeof(MatricDataTypes));
            string rowDataItem = tableRow["DataItem"].ToString();

            //Console.WriteLine("Formatting: "+input.ToString()+" into the format "+formatType);
            string output="";
            bool uoutput = false;
            double _input = Convert.ToDouble(input);

            //if simvar name is in the unique format array then send it down the switch default
            uoutput = uniqueFormats.Any(format => rowDataItem.Contains(format));

            formatType = uoutput ? "unique" : formatType;
            
            switch (formatType)
            {
                case "output_decimal":
                    output = $"{Math.Round(_input,2)}";
                    break;

                case "output_number":
                    
                    output = $"{Math.Round(_input)}";
                    break;

                case "output_heading":
                    output = $"{Rad2deg(_input):F0}";
                    break;

                case "output_transponder":
                    output = _input.ToString().PadLeft(3, '0');
                    break;

                case "output_frequency":
                    string inputstring = _input.ToString();
                    output = inputstring;
                    output = inputstring != "0" ? $"{inputstring.Substring(0, 3)}.{inputstring.Substring(3, 3)}" : null;
                    break;

                case "button":
                    output = Math.Round(_input) == 1 ? "true" : "false";
                    break;

                default:
                    //now we'll handle formatType based on unique cases by looking at the SimVar name
                    switch(rowDataItem)
                    {
                        case string s when s.Contains("AUTOPILOT VERTICAL HOLD VAR"):
                            output = Convert.ToString(Math.Round(_input / 1.66) * 100);
                            break;
                        case string s when s.Contains("TRANSPONDER STATE"):
                            output = EnumToString(Convert.ToInt32(Math.Round(_input)), typeof(TransponderState));
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{rowDataItem}:{formatType}:{output}");
            return output;
        }

        static double Deg2rad(double deg)
        {
            return deg * (Math.PI / 180);
        }
        static double Rad2deg(double rad)
        {
            return rad * (180 / Math.PI);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteLog("User Triggered XML Save");
            SaveXML();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void openAppDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void retrySimConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simconnect = null;

            WriteLog("Retrying SimConnect Connection");
            RunSimConnect = true;
            InitDataRequest();
            SimConnectSetStatus(2);
        }

        private void retryMatricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteLog("Retrying Matric Connection");
            RunMatric = true;
            MatricSetStatus(2);
            if (matric != null)
            {
                MatricGetClients();
            }
            else
            {
                InitMatric();
            }
        }

        private void forceDataSyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML();
            InitDataRequest();
        }

        private void viewSimVarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.flightsimulator.com/html/Programming_Tools/SimVars/Simulation_Variables.htm");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1aluHcOkbjMNuti3EaJjW7r367VbIRYc-aW5vFRlapKk/edit?usp=sharing");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/channels/537764560791273472/748140032258342942");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm AboutForm = new AboutForm();
            AboutForm.ShowDialog();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FeelSoMoon/SimConnect2Matric2");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/donate/?business=PGG4UGGB7V6SL&no_recurring=0&item_name=Donate+so+that+Lando+may+have+all+the+biscuits+his+heart+desires.&currency_code=GBP");
        }
    }
}
