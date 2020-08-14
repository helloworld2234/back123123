namespace BackTesting {
    partial class BACK_TEST_FORM {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BACK_TEST_FORM));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.target_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.default_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EndDayPicker = new System.Windows.Forms.DateTimePicker();
            this.StartDayPicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sim_search_text = new System.Windows.Forms.TextBox();
            this.sim_search_btn = new System.Windows.Forms.Button();
            this.sim_item_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.corr_calc_btn = new System.Windows.Forms.Button();
            this.sim_bar = new System.Windows.Forms.ProgressBar();
            this.sim_result_grid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kospi_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.req_market_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Get_user_server = new System.Windows.Forms.Label();
            this.Get_user_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Account_list_combo = new System.Windows.Forms.ComboBox();
            this.Get_user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Get_Deposit = new System.Windows.Forms.Label();
            this.Log_Text = new System.Windows.Forms.TextBox();
            this.Kiwoom_Login_btn = new System.Windows.Forms.Button();
            this.Deposit_btn = new System.Windows.Forms.Button();
            this.키움API = new AxKHOpenAPILib.AxKHOpenAPI();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.target_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.default_graph)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sim_item_grid)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sim_result_grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kospi_chart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.키움API)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 771);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.target_graph);
            this.tabPage1.Controls.Add(this.default_graph);
            this.tabPage1.Controls.Add(this.EndDayPicker);
            this.tabPage1.Controls.Add(this.StartDayPicker);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1079, 742);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "유사도&박스권 돌파";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // target_graph
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.target_graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.target_graph.Legends.Add(legend1);
            this.target_graph.Location = new System.Drawing.Point(314, 366);
            this.target_graph.Name = "target_graph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.target_graph.Series.Add(series1);
            this.target_graph.Size = new System.Drawing.Size(759, 357);
            this.target_graph.TabIndex = 7;
            this.target_graph.Text = "차트";
            // 
            // default_graph
            // 
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.default_graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.default_graph.Legends.Add(legend2);
            this.default_graph.Location = new System.Drawing.Point(314, 3);
            this.default_graph.Name = "default_graph";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.default_graph.Series.Add(series2);
            this.default_graph.Size = new System.Drawing.Size(759, 357);
            this.default_graph.TabIndex = 6;
            this.default_graph.Text = "차트";
            // 
            // EndDayPicker
            // 
            this.EndDayPicker.Location = new System.Drawing.Point(3, 41);
            this.EndDayPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndDayPicker.MaxDate = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            this.EndDayPicker.MinDate = new System.DateTime(2016, 7, 10, 0, 0, 0, 0);
            this.EndDayPicker.Name = "EndDayPicker";
            this.EndDayPicker.Size = new System.Drawing.Size(301, 25);
            this.EndDayPicker.TabIndex = 5;
            this.EndDayPicker.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            this.EndDayPicker.CloseUp += new System.EventHandler(this.EndDayPicker_ValueChanged);
            // 
            // StartDayPicker
            // 
            this.StartDayPicker.Location = new System.Drawing.Point(3, 8);
            this.StartDayPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartDayPicker.MaxDate = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            this.StartDayPicker.MinDate = new System.DateTime(2016, 7, 11, 0, 0, 0, 0);
            this.StartDayPicker.Name = "StartDayPicker";
            this.StartDayPicker.Size = new System.Drawing.Size(301, 25);
            this.StartDayPicker.TabIndex = 4;
            this.StartDayPicker.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            this.StartDayPicker.CloseUp += new System.EventHandler(this.StartDayPicker_ValueChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(3, 74);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(305, 656);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel2);
            this.tabPage5.Controls.Add(this.sim_item_grid);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(297, 627);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "종목선택";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.86432F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.13568F));
            this.tableLayoutPanel2.Controls.Add(this.sim_search_text, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sim_search_btn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // sim_search_text
            // 
            this.sim_search_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sim_search_text.Location = new System.Drawing.Point(3, 4);
            this.sim_search_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sim_search_text.Name = "sim_search_text";
            this.sim_search_text.Size = new System.Drawing.Size(203, 25);
            this.sim_search_text.TabIndex = 1;
            // 
            // sim_search_btn
            // 
            this.sim_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sim_search_btn.Location = new System.Drawing.Point(212, 4);
            this.sim_search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sim_search_btn.Name = "sim_search_btn";
            this.sim_search_btn.Size = new System.Drawing.Size(73, 26);
            this.sim_search_btn.TabIndex = 2;
            this.sim_search_btn.Text = "검색";
            this.sim_search_btn.UseVisualStyleBackColor = true;
            this.sim_search_btn.Click += new System.EventHandler(this.sim_search_btn_Click);
            // 
            // sim_item_grid
            // 
            this.sim_item_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sim_item_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.sim_item_grid.Location = new System.Drawing.Point(3, 37);
            this.sim_item_grid.Name = "sim_item_grid";
            this.sim_item_grid.ReadOnly = true;
            this.sim_item_grid.RowTemplate.Height = 27;
            this.sim_item_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sim_item_grid.Size = new System.Drawing.Size(288, 583);
            this.sim_item_grid.TabIndex = 3;
            this.sim_item_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sim_item_grid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "종목코드";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "종목이름";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel3);
            this.tabPage6.Controls.Add(this.sim_result_grid);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Size = new System.Drawing.Size(297, 627);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "유사도";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.75194F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.24806F));
            this.tableLayoutPanel3.Controls.Add(this.corr_calc_btn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.sim_bar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(289, 38);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // corr_calc_btn
            // 
            this.corr_calc_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corr_calc_btn.Location = new System.Drawing.Point(169, 4);
            this.corr_calc_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.corr_calc_btn.Name = "corr_calc_btn";
            this.corr_calc_btn.Size = new System.Drawing.Size(117, 30);
            this.corr_calc_btn.TabIndex = 0;
            this.corr_calc_btn.Text = "유사도 계산";
            this.corr_calc_btn.UseVisualStyleBackColor = true;
            this.corr_calc_btn.Click += new System.EventHandler(this.corr_calc_btn_Click);
            // 
            // sim_bar
            // 
            this.sim_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sim_bar.Location = new System.Drawing.Point(3, 4);
            this.sim_bar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sim_bar.Name = "sim_bar";
            this.sim_bar.Size = new System.Drawing.Size(160, 30);
            this.sim_bar.TabIndex = 1;
            // 
            // sim_result_grid
            // 
            this.sim_result_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sim_result_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.sim_result_grid.Location = new System.Drawing.Point(2, 44);
            this.sim_result_grid.Name = "sim_result_grid";
            this.sim_result_grid.ReadOnly = true;
            this.sim_result_grid.RowTemplate.Height = 27;
            this.sim_result_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sim_result_grid.Size = new System.Drawing.Size(289, 576);
            this.sim_result_grid.TabIndex = 4;
            this.sim_result_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sim_result_grid_CellClick);
            this.sim_result_grid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sim_result_grid_key);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "종목이름";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "유사도";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kospi_chart);
            this.tabPage2.Controls.Add(this.req_market_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1079, 742);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "장세판단";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kospi_chart
            // 
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartArea1";
            this.kospi_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.kospi_chart.Legends.Add(legend3);
            this.kospi_chart.Location = new System.Drawing.Point(6, 7);
            this.kospi_chart.Name = "kospi_chart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.kospi_chart.Series.Add(series3);
            this.kospi_chart.Size = new System.Drawing.Size(916, 367);
            this.kospi_chart.TabIndex = 10;
            this.kospi_chart.Text = "차트";
            // 
            // req_market_btn
            // 
            this.req_market_btn.Location = new System.Drawing.Point(960, 7);
            this.req_market_btn.Name = "req_market_btn";
            this.req_market_btn.Size = new System.Drawing.Size(113, 28);
            this.req_market_btn.TabIndex = 9;
            this.req_market_btn.Text = "데이터 요청";
            this.req_market_btn.UseVisualStyleBackColor = true;
            this.req_market_btn.Click += new System.EventHandler(this.req_market_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1079, 742);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "모멘텀";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1079, 742);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "포트폴리오 최적화&샤프지수";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1079, 742);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "테스트공간";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.09009F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.90991F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Get_user_server, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Get_user_id, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Account_list_combo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Get_user_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Get_Deposit, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1105, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "예수금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Get_user_server
            // 
            this.Get_user_server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_user_server.AutoSize = true;
            this.Get_user_server.Location = new System.Drawing.Point(92, 84);
            this.Get_user_server.Name = "Get_user_server";
            this.Get_user_server.Size = new System.Drawing.Size(127, 28);
            this.Get_user_server.TabIndex = 8;
            this.Get_user_server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Get_user_id
            // 
            this.Get_user_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_user_id.AutoSize = true;
            this.Get_user_id.Location = new System.Drawing.Point(92, 56);
            this.Get_user_id.Name = "Get_user_id";
            this.Get_user_id.Size = new System.Drawing.Size(127, 28);
            this.Get_user_id.TabIndex = 7;
            this.Get_user_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "아이디";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "접속서버";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_list_combo
            // 
            this.Account_list_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_list_combo.FormattingEnabled = true;
            this.Account_list_combo.Location = new System.Drawing.Point(92, 3);
            this.Account_list_combo.Name = "Account_list_combo";
            this.Account_list_combo.Size = new System.Drawing.Size(127, 23);
            this.Account_list_combo.TabIndex = 5;
            // 
            // Get_user_name
            // 
            this.Get_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_user_name.AutoSize = true;
            this.Get_user_name.Location = new System.Drawing.Point(92, 28);
            this.Get_user_name.Name = "Get_user_name";
            this.Get_user_name.Size = new System.Drawing.Size(127, 28);
            this.Get_user_name.TabIndex = 6;
            this.Get_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Get_Deposit
            // 
            this.Get_Deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_Deposit.AutoSize = true;
            this.Get_Deposit.Location = new System.Drawing.Point(92, 112);
            this.Get_Deposit.Name = "Get_Deposit";
            this.Get_Deposit.Size = new System.Drawing.Size(127, 23);
            this.Get_Deposit.TabIndex = 10;
            this.Get_Deposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log_Text
            // 
            this.Log_Text.Location = new System.Drawing.Point(1105, 238);
            this.Log_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Log_Text.Multiline = true;
            this.Log_Text.Name = "Log_Text";
            this.Log_Text.ReadOnly = true;
            this.Log_Text.Size = new System.Drawing.Size(222, 542);
            this.Log_Text.TabIndex = 1;
            this.Log_Text.Text = "\r\n";
            // 
            // Kiwoom_Login_btn
            // 
            this.Kiwoom_Login_btn.Location = new System.Drawing.Point(1105, 42);
            this.Kiwoom_Login_btn.Name = "Kiwoom_Login_btn";
            this.Kiwoom_Login_btn.Size = new System.Drawing.Size(134, 35);
            this.Kiwoom_Login_btn.TabIndex = 1;
            this.Kiwoom_Login_btn.Text = "키움증권 로그인";
            this.Kiwoom_Login_btn.UseVisualStyleBackColor = true;
            this.Kiwoom_Login_btn.Click += new System.EventHandler(this.Kiwoom_Login_btn_Click);
            // 
            // Deposit_btn
            // 
            this.Deposit_btn.Location = new System.Drawing.Point(1245, 42);
            this.Deposit_btn.Name = "Deposit_btn";
            this.Deposit_btn.Size = new System.Drawing.Size(92, 35);
            this.Deposit_btn.TabIndex = 3;
            this.Deposit_btn.Text = "예수금조회";
            this.Deposit_btn.UseVisualStyleBackColor = true;
            this.Deposit_btn.Click += new System.EventHandler(this.Deposit_btn_Click);
            // 
            // 키움API
            // 
            this.키움API.Enabled = true;
            this.키움API.Location = new System.Drawing.Point(1382, 15);
            this.키움API.Name = "키움API";
            this.키움API.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("키움API.OcxState")));
            this.키움API.Size = new System.Drawing.Size(106, 29);
            this.키움API.TabIndex = 2;
            // 
            // BACK_TEST_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 801);
            this.Controls.Add(this.Deposit_btn);
            this.Controls.Add(this.Kiwoom_Login_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.키움API);
            this.Controls.Add(this.Log_Text);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BACK_TEST_FORM";
            this.Text = "백테스팅용";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.target_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.default_graph)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sim_item_grid)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sim_result_grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kospi_chart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.키움API)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox Log_Text;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker EndDayPicker;
        private System.Windows.Forms.DateTimePicker StartDayPicker;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button sim_search_btn;
        private System.Windows.Forms.TextBox sim_search_text;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ProgressBar sim_bar;
        private System.Windows.Forms.Button corr_calc_btn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataVisualization.Charting.Chart default_graph;
        private System.Windows.Forms.DataGridView sim_item_grid;
        private System.Windows.Forms.DataGridView sim_result_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart target_graph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private AxKHOpenAPILib.AxKHOpenAPI 키움API;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Account_list_combo;
        private System.Windows.Forms.Label Get_user_server;
        private System.Windows.Forms.Label Get_user_id;
        private System.Windows.Forms.Label Get_user_name;
        private System.Windows.Forms.Button Kiwoom_Login_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Get_Deposit;
        private System.Windows.Forms.Button Deposit_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button req_market_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart kospi_chart;
    }
}

