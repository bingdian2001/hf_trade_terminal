﻿
namespace HaiFeng
{
	partial class HFForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFForm));
			this.comboBoxMsg = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxSkins = new System.Windows.Forms.ComboBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxPwd = new System.Windows.Forms.TextBox();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.comboBoxServer = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.buttonSell = new System.Windows.Forms.Button();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
			this.labelBidVol = new System.Windows.Forms.Label();
			this.labelLower = new System.Windows.Forms.Label();
			this.labelBid = new System.Windows.Forms.Label();
			this.labelAskVol = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelOffset = new System.Windows.Forms.Label();
			this.labelUpper = new System.Windows.Forms.Label();
			this.labelAsk = new System.Windows.Forms.Label();
			this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
			this.comboBoxOffset = new System.Windows.Forms.ComboBox();
			this.comboBoxInstrument = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageOrder = new System.Windows.Forms.TabPage();
			this.panelOrder = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonCancelAll = new System.Windows.Forms.Button();
			this.radioButtonFilled = new System.Windows.Forms.RadioButton();
			this.radioButtonError = new System.Windows.Forms.RadioButton();
			this.radioButtonCancel = new System.Windows.Forms.RadioButton();
			this.radioButtonNormal = new System.Windows.Forms.RadioButton();
			this.radioButtonAll = new System.Windows.Forms.RadioButton();
			this.tabPageTrade = new System.Windows.Forms.TabPage();
			this.tabPagePosi = new System.Windows.Forms.TabPage();
			this.tabPageInfo = new System.Windows.Forms.TabPage();
			this.tabPageInstrument = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageOrder.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxMsg
			// 
			this.comboBoxMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.comboBoxMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMsg.FormattingEnabled = true;
			this.comboBoxMsg.Location = new System.Drawing.Point(0, 657);
			this.comboBoxMsg.Name = "comboBoxMsg";
			this.comboBoxMsg.Size = new System.Drawing.Size(1343, 20);
			this.comboBoxMsg.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBoxSkins);
			this.panel1.Controls.Add(this.buttonLogin);
			this.panel1.Controls.Add(this.textBoxPwd);
			this.panel1.Controls.Add(this.textBoxUser);
			this.panel1.Controls.Add(this.comboBoxServer);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1343, 34);
			this.panel1.TabIndex = 0;
			// 
			// comboBoxSkins
			// 
			this.comboBoxSkins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSkins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSkins.FormattingEnabled = true;
			this.comboBoxSkins.Location = new System.Drawing.Point(1210, 6);
			this.comboBoxSkins.Name = "comboBoxSkins";
			this.comboBoxSkins.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSkins.Sorted = true;
			this.comboBoxSkins.TabIndex = 5;
			this.comboBoxSkins.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkins_SelectedIndexChanged);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(456, 4);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "登录";
			this.buttonLogin.UseVisualStyleBackColor = true;
			// 
			// textBoxPwd
			// 
			this.textBoxPwd.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxPwd.Location = new System.Drawing.Point(341, 6);
			this.textBoxPwd.Name = "textBoxPwd";
			this.textBoxPwd.PasswordChar = '*';
			this.textBoxPwd.Size = new System.Drawing.Size(108, 21);
			this.textBoxPwd.TabIndex = 3;
			// 
			// textBoxUser
			// 
			this.textBoxUser.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxUser.Location = new System.Drawing.Point(203, 6);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(109, 21);
			this.textBoxUser.TabIndex = 2;
			// 
			// comboBoxServer
			// 
			this.comboBoxServer.BackColor = System.Drawing.SystemColors.Control;
			this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxServer.FormattingEnabled = true;
			this.comboBoxServer.Location = new System.Drawing.Point(53, 6);
			this.comboBoxServer.Name = "comboBoxServer";
			this.comboBoxServer.Size = new System.Drawing.Size(121, 20);
			this.comboBoxServer.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(312, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "密码";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "帐号";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 34);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(1343, 623);
			this.splitContainer1.SplitterDistance = 48;
			this.splitContainer1.TabIndex = 5;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer3.Size = new System.Drawing.Size(1343, 571);
			this.splitContainer3.SplitterDistance = 106;
			this.splitContainer3.TabIndex = 2;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.buttonSell);
			this.splitContainer2.Panel1.Controls.Add(this.buttonBuy);
			this.splitContainer2.Panel1.Controls.Add(this.numericUpDownVolume);
			this.splitContainer2.Panel1.Controls.Add(this.labelBidVol);
			this.splitContainer2.Panel1.Controls.Add(this.labelLower);
			this.splitContainer2.Panel1.Controls.Add(this.labelBid);
			this.splitContainer2.Panel1.Controls.Add(this.labelAskVol);
			this.splitContainer2.Panel1.Controls.Add(this.label4);
			this.splitContainer2.Panel1.Controls.Add(this.label5);
			this.splitContainer2.Panel1.Controls.Add(this.labelPrice);
			this.splitContainer2.Panel1.Controls.Add(this.label6);
			this.splitContainer2.Panel1.Controls.Add(this.labelOffset);
			this.splitContainer2.Panel1.Controls.Add(this.labelUpper);
			this.splitContainer2.Panel1.Controls.Add(this.labelAsk);
			this.splitContainer2.Panel1.Controls.Add(this.numericUpDownOffset);
			this.splitContainer2.Panel1.Controls.Add(this.numericUpDownPrice);
			this.splitContainer2.Panel1.Controls.Add(this.comboBoxOffset);
			this.splitContainer2.Panel1.Controls.Add(this.comboBoxInstrument);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new System.Drawing.Size(1343, 461);
			this.splitContainer2.SplitterDistance = 186;
			this.splitContainer2.TabIndex = 1;
			// 
			// buttonSell
			// 
			this.buttonSell.Location = new System.Drawing.Point(97, 160);
			this.buttonSell.Name = "buttonSell";
			this.buttonSell.Size = new System.Drawing.Size(75, 23);
			this.buttonSell.TabIndex = 24;
			this.buttonSell.Text = "卖出";
			this.buttonSell.UseVisualStyleBackColor = true;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(21, 160);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(75, 23);
			this.buttonBuy.TabIndex = 23;
			this.buttonBuy.Text = "买入";
			this.buttonBuy.UseVisualStyleBackColor = true;
			// 
			// numericUpDownVolume
			// 
			this.numericUpDownVolume.Location = new System.Drawing.Point(45, 68);
			this.numericUpDownVolume.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numericUpDownVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownVolume.Name = "numericUpDownVolume";
			this.numericUpDownVolume.Size = new System.Drawing.Size(87, 21);
			this.numericUpDownVolume.TabIndex = 16;
			this.numericUpDownVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelBidVol
			// 
			this.labelBidVol.AutoSize = true;
			this.labelBidVol.Location = new System.Drawing.Point(104, 214);
			this.labelBidVol.Name = "labelBidVol";
			this.labelBidVol.Size = new System.Drawing.Size(41, 12);
			this.labelBidVol.TabIndex = 21;
			this.labelBidVol.Text = "label1";
			// 
			// labelLower
			// 
			this.labelLower.AutoSize = true;
			this.labelLower.Location = new System.Drawing.Point(136, 53);
			this.labelLower.Name = "labelLower";
			this.labelLower.Size = new System.Drawing.Size(41, 12);
			this.labelLower.TabIndex = 20;
			this.labelLower.Text = "label1";
			// 
			// labelBid
			// 
			this.labelBid.AutoSize = true;
			this.labelBid.Location = new System.Drawing.Point(104, 192);
			this.labelBid.Name = "labelBid";
			this.labelBid.Size = new System.Drawing.Size(41, 12);
			this.labelBid.TabIndex = 19;
			this.labelBid.Text = "label1";
			// 
			// labelAskVol
			// 
			this.labelAskVol.AutoSize = true;
			this.labelAskVol.Location = new System.Drawing.Point(23, 214);
			this.labelAskVol.Name = "labelAskVol";
			this.labelAskVol.Size = new System.Drawing.Size(41, 12);
			this.labelAskVol.TabIndex = 15;
			this.labelAskVol.Text = "label1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 17;
			this.label4.Text = "手数";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "合约";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(12, 42);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(29, 12);
			this.labelPrice.TabIndex = 13;
			this.labelPrice.Text = "价格";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "偏移";
			// 
			// labelOffset
			// 
			this.labelOffset.AutoSize = true;
			this.labelOffset.Location = new System.Drawing.Point(12, 100);
			this.labelOffset.Name = "labelOffset";
			this.labelOffset.Size = new System.Drawing.Size(29, 12);
			this.labelOffset.TabIndex = 11;
			this.labelOffset.Text = "开平";
			// 
			// labelUpper
			// 
			this.labelUpper.AutoSize = true;
			this.labelUpper.Location = new System.Drawing.Point(136, 35);
			this.labelUpper.Name = "labelUpper";
			this.labelUpper.Size = new System.Drawing.Size(41, 12);
			this.labelUpper.TabIndex = 10;
			this.labelUpper.Text = "label1";
			// 
			// labelAsk
			// 
			this.labelAsk.AutoSize = true;
			this.labelAsk.Location = new System.Drawing.Point(23, 192);
			this.labelAsk.Name = "labelAsk";
			this.labelAsk.Size = new System.Drawing.Size(41, 12);
			this.labelAsk.TabIndex = 9;
			this.labelAsk.Text = "label1";
			// 
			// numericUpDownOffset
			// 
			this.numericUpDownOffset.Location = new System.Drawing.Point(45, 125);
			this.numericUpDownOffset.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numericUpDownOffset.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.numericUpDownOffset.Name = "numericUpDownOffset";
			this.numericUpDownOffset.Size = new System.Drawing.Size(86, 21);
			this.numericUpDownOffset.TabIndex = 22;
			// 
			// numericUpDownPrice
			// 
			this.numericUpDownPrice.Location = new System.Drawing.Point(45, 38);
			this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numericUpDownPrice.Name = "numericUpDownPrice";
			this.numericUpDownPrice.Size = new System.Drawing.Size(87, 21);
			this.numericUpDownPrice.TabIndex = 8;
			// 
			// comboBoxOffset
			// 
			this.comboBoxOffset.FormattingEnabled = true;
			this.comboBoxOffset.Location = new System.Drawing.Point(45, 98);
			this.comboBoxOffset.Name = "comboBoxOffset";
			this.comboBoxOffset.Size = new System.Drawing.Size(88, 20);
			this.comboBoxOffset.TabIndex = 18;
			// 
			// comboBoxInstrument
			// 
			this.comboBoxInstrument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxInstrument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxInstrument.FormattingEnabled = true;
			this.comboBoxInstrument.Location = new System.Drawing.Point(45, 9);
			this.comboBoxInstrument.Name = "comboBoxInstrument";
			this.comboBoxInstrument.Size = new System.Drawing.Size(121, 20);
			this.comboBoxInstrument.TabIndex = 7;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageOrder);
			this.tabControl1.Controls.Add(this.tabPageTrade);
			this.tabControl1.Controls.Add(this.tabPagePosi);
			this.tabControl1.Controls.Add(this.tabPageInfo);
			this.tabControl1.Controls.Add(this.tabPageInstrument);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1153, 461);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageOrder
			// 
			this.tabPageOrder.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageOrder.Controls.Add(this.panelOrder);
			this.tabPageOrder.Controls.Add(this.panel2);
			this.tabPageOrder.Location = new System.Drawing.Point(4, 22);
			this.tabPageOrder.Name = "tabPageOrder";
			this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOrder.Size = new System.Drawing.Size(1145, 435);
			this.tabPageOrder.TabIndex = 0;
			this.tabPageOrder.Text = "委托";
			// 
			// panelOrder
			// 
			this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelOrder.Location = new System.Drawing.Point(3, 30);
			this.panelOrder.Name = "panelOrder";
			this.panelOrder.Size = new System.Drawing.Size(1139, 402);
			this.panelOrder.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Controls.Add(this.buttonCancelAll);
			this.panel2.Controls.Add(this.radioButtonFilled);
			this.panel2.Controls.Add(this.radioButtonError);
			this.panel2.Controls.Add(this.radioButtonCancel);
			this.panel2.Controls.Add(this.radioButtonNormal);
			this.panel2.Controls.Add(this.radioButtonAll);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1139, 27);
			this.panel2.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
			this.buttonCancel.Location = new System.Drawing.Point(274, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "撤  单";
			this.buttonCancel.UseVisualStyleBackColor = false;
			// 
			// buttonCancelAll
			// 
			this.buttonCancelAll.BackColor = System.Drawing.Color.Transparent;
			this.buttonCancelAll.Location = new System.Drawing.Point(355, 3);
			this.buttonCancelAll.Name = "buttonCancelAll";
			this.buttonCancelAll.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelAll.TabIndex = 4;
			this.buttonCancelAll.Text = "全  撤";
			this.buttonCancelAll.UseVisualStyleBackColor = false;
			// 
			// radioButtonFilled
			// 
			this.radioButtonFilled.AutoSize = true;
			this.radioButtonFilled.Location = new System.Drawing.Point(207, 6);
			this.radioButtonFilled.Name = "radioButtonFilled";
			this.radioButtonFilled.Size = new System.Drawing.Size(47, 16);
			this.radioButtonFilled.TabIndex = 3;
			this.radioButtonFilled.Text = "全成";
			this.radioButtonFilled.UseVisualStyleBackColor = true;
			// 
			// radioButtonError
			// 
			this.radioButtonError.AutoSize = true;
			this.radioButtonError.Location = new System.Drawing.Point(157, 6);
			this.radioButtonError.Name = "radioButtonError";
			this.radioButtonError.Size = new System.Drawing.Size(47, 16);
			this.radioButtonError.TabIndex = 2;
			this.radioButtonError.Text = "错单";
			this.radioButtonError.UseVisualStyleBackColor = true;
			// 
			// radioButtonCancel
			// 
			this.radioButtonCancel.AutoSize = true;
			this.radioButtonCancel.Location = new System.Drawing.Point(107, 6);
			this.radioButtonCancel.Name = "radioButtonCancel";
			this.radioButtonCancel.Size = new System.Drawing.Size(47, 16);
			this.radioButtonCancel.TabIndex = 2;
			this.radioButtonCancel.Text = "撤单";
			this.radioButtonCancel.UseVisualStyleBackColor = true;
			// 
			// radioButtonNormal
			// 
			this.radioButtonNormal.AutoSize = true;
			this.radioButtonNormal.Location = new System.Drawing.Point(57, 6);
			this.radioButtonNormal.Name = "radioButtonNormal";
			this.radioButtonNormal.Size = new System.Drawing.Size(47, 16);
			this.radioButtonNormal.TabIndex = 1;
			this.radioButtonNormal.Text = "未成";
			this.radioButtonNormal.UseVisualStyleBackColor = true;
			// 
			// radioButtonAll
			// 
			this.radioButtonAll.AutoSize = true;
			this.radioButtonAll.Checked = true;
			this.radioButtonAll.Location = new System.Drawing.Point(7, 6);
			this.radioButtonAll.Name = "radioButtonAll";
			this.radioButtonAll.Size = new System.Drawing.Size(47, 16);
			this.radioButtonAll.TabIndex = 0;
			this.radioButtonAll.TabStop = true;
			this.radioButtonAll.Text = "全部";
			this.radioButtonAll.UseVisualStyleBackColor = true;
			// 
			// tabPageTrade
			// 
			this.tabPageTrade.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageTrade.Location = new System.Drawing.Point(4, 22);
			this.tabPageTrade.Name = "tabPageTrade";
			this.tabPageTrade.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTrade.Size = new System.Drawing.Size(1145, 435);
			this.tabPageTrade.TabIndex = 4;
			this.tabPageTrade.Text = "成交";
			// 
			// tabPagePosi
			// 
			this.tabPagePosi.BackColor = System.Drawing.SystemColors.Control;
			this.tabPagePosi.Location = new System.Drawing.Point(4, 22);
			this.tabPagePosi.Name = "tabPagePosi";
			this.tabPagePosi.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePosi.Size = new System.Drawing.Size(1145, 435);
			this.tabPagePosi.TabIndex = 5;
			this.tabPagePosi.Text = "持仓";
			// 
			// tabPageInfo
			// 
			this.tabPageInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
			this.tabPageInfo.Name = "tabPageInfo";
			this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInfo.Size = new System.Drawing.Size(1145, 435);
			this.tabPageInfo.TabIndex = 3;
			this.tabPageInfo.Text = "消息";
			// 
			// tabPageInstrument
			// 
			this.tabPageInstrument.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageInstrument.Location = new System.Drawing.Point(4, 22);
			this.tabPageInstrument.Name = "tabPageInstrument";
			this.tabPageInstrument.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInstrument.Size = new System.Drawing.Size(1145, 435);
			this.tabPageInstrument.TabIndex = 2;
			this.tabPageInstrument.Text = "合约信息";
			// 
			// HFForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1343, 677);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBoxMsg);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HFForm";
			this.Text = "海风";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageOrder.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBoxMsg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TextBox textBoxPwd;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.ComboBox comboBoxServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageInfo;
		private System.Windows.Forms.TabPage tabPageInstrument;
		private System.Windows.Forms.TabPage tabPageOrder;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabPage tabPageTrade;
		private System.Windows.Forms.TabPage tabPagePosi;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton radioButtonAll;
		private System.Windows.Forms.RadioButton radioButtonNormal;
		private System.Windows.Forms.RadioButton radioButtonCancel;
		private System.Windows.Forms.RadioButton radioButtonFilled;
		private System.Windows.Forms.Button buttonCancelAll;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panelOrder;
		private System.Windows.Forms.RadioButton radioButtonError;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button buttonSell;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.NumericUpDown numericUpDownVolume;
		private System.Windows.Forms.Label labelBidVol;
		private System.Windows.Forms.Label labelLower;
		private System.Windows.Forms.Label labelBid;
		private System.Windows.Forms.Label labelAskVol;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelOffset;
		private System.Windows.Forms.Label labelUpper;
		private System.Windows.Forms.Label labelAsk;
		private System.Windows.Forms.NumericUpDown numericUpDownOffset;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
		private System.Windows.Forms.ComboBox comboBoxOffset;
		private System.Windows.Forms.ComboBox comboBoxInstrument;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ComboBox comboBoxSkins;
	}
}