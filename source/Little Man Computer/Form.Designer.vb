<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel
        Me.tlpRight = New System.Windows.Forms.TableLayoutPanel
        Me.tlpRightBottom = New System.Windows.Forms.TableLayoutPanel
        Me.lblOutbox = New System.Windows.Forms.Label
        Me.lblMEMData = New System.Windows.Forms.Label
        Me.lblCounter = New System.Windows.Forms.Label
        Me.lblInbox = New System.Windows.Forms.Label
        Me.lblMEMAddress = New System.Windows.Forms.Label
        Me.txtOutbox = New System.Windows.Forms.TextBox
        Me.txtMEMData = New System.Windows.Forms.TextBox
        Me.txtCounter = New System.Windows.Forms.TextBox
        Me.txtInbox = New System.Windows.Forms.TextBox
        Me.txtMEMAddress = New System.Windows.Forms.TextBox
        Me.txtAccumulator = New System.Windows.Forms.TextBox
        Me.lblAccumulator = New System.Windows.Forms.Label
        Me.btnInboxSubmit = New System.Windows.Forms.Button
        Me.tlpRightTop = New System.Windows.Forms.TableLayoutPanel
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnCompile = New System.Windows.Forms.Button
        Me.btnClearMessage = New System.Windows.Forms.Button
        Me.llbLoadProject = New System.Windows.Forms.LinkLabel
        Me.txtMesssage = New System.Windows.Forms.TextBox
        Me.tlpLeft = New System.Windows.Forms.TableLayoutPanel
        Me.tlpLeftBottom = New System.Windows.Forms.TableLayoutPanel
        Me.btnHalt = New System.Windows.Forms.Button
        Me.btnStep = New System.Windows.Forms.Button
        Me.btnSlow = New System.Windows.Forms.Button
        Me.btnRun = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.tlpCode = New System.Windows.Forms.TableLayoutPanel
        Me.rtbCommands1 = New System.Windows.Forms.RichTextBox
        Me.rtbCommands2 = New System.Windows.Forms.RichTextBox
        Me.rtbCommands3 = New System.Windows.Forms.RichTextBox
        Me.lblCommands1 = New System.Windows.Forms.Label
        Me.lblCommands2 = New System.Windows.Forms.Label
        Me.lblCommands3 = New System.Windows.Forms.Label
        Me.tlpMain.SuspendLayout()
        Me.tlpRight.SuspendLayout()
        Me.tlpRightBottom.SuspendLayout()
        Me.tlpRightTop.SuspendLayout()
        Me.tlpLeft.SuspendLayout()
        Me.tlpLeftBottom.SuspendLayout()
        Me.tlpCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpRight, 1, 0)
        Me.tlpMain.Controls.Add(Me.tlpLeft, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(612, 601)
        Me.tlpMain.TabIndex = 0
        '
        'tlpRight
        '
        Me.tlpRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRight.ColumnCount = 1
        Me.tlpRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRight.Controls.Add(Me.tlpRightBottom, 0, 2)
        Me.tlpRight.Controls.Add(Me.tlpRightTop, 0, 0)
        Me.tlpRight.Controls.Add(Me.txtMesssage, 0, 1)
        Me.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRight.Location = New System.Drawing.Point(200, 0)
        Me.tlpRight.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRight.Name = "tlpRight"
        Me.tlpRight.RowCount = 3
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpRight.Size = New System.Drawing.Size(412, 601)
        Me.tlpRight.TabIndex = 0
        '
        'tlpRightBottom
        '
        Me.tlpRightBottom.ColumnCount = 7
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpRightBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRightBottom.Controls.Add(Me.lblOutbox, 4, 1)
        Me.tlpRightBottom.Controls.Add(Me.lblMEMData, 2, 1)
        Me.tlpRightBottom.Controls.Add(Me.lblCounter, 0, 1)
        Me.tlpRightBottom.Controls.Add(Me.lblInbox, 4, 0)
        Me.tlpRightBottom.Controls.Add(Me.lblMEMAddress, 2, 0)
        Me.tlpRightBottom.Controls.Add(Me.txtOutbox, 5, 1)
        Me.tlpRightBottom.Controls.Add(Me.txtMEMData, 3, 1)
        Me.tlpRightBottom.Controls.Add(Me.txtCounter, 1, 1)
        Me.tlpRightBottom.Controls.Add(Me.txtInbox, 5, 0)
        Me.tlpRightBottom.Controls.Add(Me.txtMEMAddress, 3, 0)
        Me.tlpRightBottom.Controls.Add(Me.txtAccumulator, 1, 0)
        Me.tlpRightBottom.Controls.Add(Me.lblAccumulator, 0, 0)
        Me.tlpRightBottom.Controls.Add(Me.btnInboxSubmit, 6, 0)
        Me.tlpRightBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRightBottom.Location = New System.Drawing.Point(1, 550)
        Me.tlpRightBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRightBottom.Name = "tlpRightBottom"
        Me.tlpRightBottom.RowCount = 2
        Me.tlpRightBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpRightBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpRightBottom.Size = New System.Drawing.Size(410, 50)
        Me.tlpRightBottom.TabIndex = 2
        '
        'lblOutbox
        '
        Me.lblOutbox.AutoSize = True
        Me.lblOutbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOutbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOutbox.Location = New System.Drawing.Point(266, 31)
        Me.lblOutbox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblOutbox.Name = "lblOutbox"
        Me.lblOutbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOutbox.Size = New System.Drawing.Size(44, 13)
        Me.lblOutbox.TabIndex = 19
        Me.lblOutbox.Text = "Outbox:"
        Me.lblOutbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMEMData
        '
        Me.lblMEMData.AutoSize = True
        Me.lblMEMData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMEMData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMEMData.Location = New System.Drawing.Point(131, 31)
        Me.lblMEMData.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblMEMData.Name = "lblMEMData"
        Me.lblMEMData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEMData.Size = New System.Drawing.Size(79, 13)
        Me.lblMEMData.TabIndex = 18
        Me.lblMEMData.Text = "MEM Data:"
        Me.lblMEMData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCounter.Location = New System.Drawing.Point(3, 31)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCounter.Size = New System.Drawing.Size(72, 13)
        Me.lblCounter.TabIndex = 17
        Me.lblCounter.Text = "Counter:"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInbox
        '
        Me.lblInbox.AutoSize = True
        Me.lblInbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblInbox.Location = New System.Drawing.Point(266, 6)
        Me.lblInbox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblInbox.Name = "lblInbox"
        Me.lblInbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInbox.Size = New System.Drawing.Size(44, 13)
        Me.lblInbox.TabIndex = 15
        Me.lblInbox.Text = "Inbox:"
        Me.lblInbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMEMAddress
        '
        Me.lblMEMAddress.AutoSize = True
        Me.lblMEMAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMEMAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMEMAddress.Location = New System.Drawing.Point(131, 6)
        Me.lblMEMAddress.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblMEMAddress.Name = "lblMEMAddress"
        Me.lblMEMAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEMAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblMEMAddress.TabIndex = 14
        Me.lblMEMAddress.Text = "MEM Address:"
        Me.lblMEMAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOutbox
        '
        Me.txtOutbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutbox.Location = New System.Drawing.Point(316, 28)
        Me.txtOutbox.MaxLength = 3
        Me.txtOutbox.Name = "txtOutbox"
        Me.txtOutbox.ReadOnly = True
        Me.txtOutbox.Size = New System.Drawing.Size(44, 20)
        Me.txtOutbox.TabIndex = 12
        '
        'txtMEMData
        '
        Me.txtMEMData.BackColor = System.Drawing.SystemColors.Control
        Me.txtMEMData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMEMData.Location = New System.Drawing.Point(216, 28)
        Me.txtMEMData.MaxLength = 3
        Me.txtMEMData.Name = "txtMEMData"
        Me.txtMEMData.ReadOnly = True
        Me.txtMEMData.Size = New System.Drawing.Size(44, 20)
        Me.txtMEMData.TabIndex = 10
        Me.txtMEMData.Text = "000"
        '
        'txtCounter
        '
        Me.txtCounter.BackColor = System.Drawing.SystemColors.Control
        Me.txtCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCounter.Location = New System.Drawing.Point(81, 28)
        Me.txtCounter.MaxLength = 3
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.ReadOnly = True
        Me.txtCounter.Size = New System.Drawing.Size(44, 20)
        Me.txtCounter.TabIndex = 8
        Me.txtCounter.Text = "0"
        '
        'txtInbox
        '
        Me.txtInbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInbox.Location = New System.Drawing.Point(316, 3)
        Me.txtInbox.MaxLength = 3
        Me.txtInbox.Name = "txtInbox"
        Me.txtInbox.ReadOnly = True
        Me.txtInbox.Size = New System.Drawing.Size(44, 20)
        Me.txtInbox.TabIndex = 5
        '
        'txtMEMAddress
        '
        Me.txtMEMAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtMEMAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMEMAddress.Location = New System.Drawing.Point(216, 3)
        Me.txtMEMAddress.MaxLength = 3
        Me.txtMEMAddress.Name = "txtMEMAddress"
        Me.txtMEMAddress.ReadOnly = True
        Me.txtMEMAddress.Size = New System.Drawing.Size(44, 20)
        Me.txtMEMAddress.TabIndex = 3
        Me.txtMEMAddress.Text = "00"
        '
        'txtAccumulator
        '
        Me.txtAccumulator.BackColor = System.Drawing.SystemColors.Control
        Me.txtAccumulator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAccumulator.Location = New System.Drawing.Point(81, 3)
        Me.txtAccumulator.MaxLength = 3
        Me.txtAccumulator.Name = "txtAccumulator"
        Me.txtAccumulator.ReadOnly = True
        Me.txtAccumulator.Size = New System.Drawing.Size(44, 20)
        Me.txtAccumulator.TabIndex = 0
        Me.txtAccumulator.Text = "0"
        '
        'lblAccumulator
        '
        Me.lblAccumulator.AutoSize = True
        Me.lblAccumulator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccumulator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAccumulator.Location = New System.Drawing.Point(3, 6)
        Me.lblAccumulator.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.lblAccumulator.Name = "lblAccumulator"
        Me.lblAccumulator.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAccumulator.Size = New System.Drawing.Size(72, 13)
        Me.lblAccumulator.TabIndex = 13
        Me.lblAccumulator.Text = "Accumulator:"
        Me.lblAccumulator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInboxSubmit
        '
        Me.btnInboxSubmit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInboxSubmit.Enabled = False
        Me.btnInboxSubmit.Location = New System.Drawing.Point(366, 3)
        Me.btnInboxSubmit.Name = "btnInboxSubmit"
        Me.btnInboxSubmit.Size = New System.Drawing.Size(41, 19)
        Me.btnInboxSubmit.TabIndex = 20
        Me.btnInboxSubmit.Text = "Enter"
        Me.btnInboxSubmit.UseVisualStyleBackColor = True
        '
        'tlpRightTop
        '
        Me.tlpRightTop.ColumnCount = 4
        Me.tlpRightTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.tlpRightTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRightTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpRightTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpRightTop.Controls.Add(Me.lblMessage, 0, 0)
        Me.tlpRightTop.Controls.Add(Me.btnCompile, 3, 0)
        Me.tlpRightTop.Controls.Add(Me.btnClearMessage, 2, 0)
        Me.tlpRightTop.Controls.Add(Me.llbLoadProject, 1, 0)
        Me.tlpRightTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRightTop.Location = New System.Drawing.Point(1, 1)
        Me.tlpRightTop.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRightTop.Name = "tlpRightTop"
        Me.tlpRightTop.RowCount = 1
        Me.tlpRightTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRightTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpRightTop.Size = New System.Drawing.Size(410, 22)
        Me.tlpRightTop.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.Location = New System.Drawing.Point(3, 5)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(162, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Messages:"
        '
        'btnCompile
        '
        Me.btnCompile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCompile.Location = New System.Drawing.Point(356, 0)
        Me.btnCompile.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(54, 22)
        Me.btnCompile.TabIndex = 1
        Me.btnCompile.Text = "Compile"
        Me.btnCompile.UseVisualStyleBackColor = True
        '
        'btnClearMessage
        '
        Me.btnClearMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearMessage.Location = New System.Drawing.Point(310, 0)
        Me.btnClearMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClearMessage.Name = "btnClearMessage"
        Me.btnClearMessage.Size = New System.Drawing.Size(46, 22)
        Me.btnClearMessage.TabIndex = 2
        Me.btnClearMessage.Text = "Clear"
        Me.btnClearMessage.UseVisualStyleBackColor = True
        '
        'llbLoadProject
        '
        Me.llbLoadProject.AutoSize = True
        Me.llbLoadProject.Dock = System.Windows.Forms.DockStyle.Right
        Me.llbLoadProject.Location = New System.Drawing.Point(231, 4)
        Me.llbLoadProject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.llbLoadProject.Name = "llbLoadProject"
        Me.llbLoadProject.Size = New System.Drawing.Size(76, 14)
        Me.llbLoadProject.TabIndex = 3
        Me.llbLoadProject.TabStop = True
        Me.llbLoadProject.Text = "Load a Project"
        '
        'txtMesssage
        '
        Me.txtMesssage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMesssage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMesssage.Location = New System.Drawing.Point(1, 24)
        Me.txtMesssage.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMesssage.Multiline = True
        Me.txtMesssage.Name = "txtMesssage"
        Me.txtMesssage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMesssage.Size = New System.Drawing.Size(410, 525)
        Me.txtMesssage.TabIndex = 1
        Me.txtMesssage.Text = resources.GetString("txtMesssage.Text")
        '
        'tlpLeft
        '
        Me.tlpLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpLeft.ColumnCount = 1
        Me.tlpLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Controls.Add(Me.tlpLeftBottom, 0, 1)
        Me.tlpLeft.Controls.Add(Me.tlpCode, 0, 0)
        Me.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLeft.Location = New System.Drawing.Point(0, 0)
        Me.tlpLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLeft.Name = "tlpLeft"
        Me.tlpLeft.RowCount = 2
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpLeft.Size = New System.Drawing.Size(200, 601)
        Me.tlpLeft.TabIndex = 1
        '
        'tlpLeftBottom
        '
        Me.tlpLeftBottom.ColumnCount = 3
        Me.tlpLeftBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpLeftBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpLeftBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpLeftBottom.Controls.Add(Me.btnHalt, 2, 1)
        Me.tlpLeftBottom.Controls.Add(Me.btnStep, 1, 1)
        Me.tlpLeftBottom.Controls.Add(Me.btnSlow, 0, 1)
        Me.tlpLeftBottom.Controls.Add(Me.btnRun, 2, 0)
        Me.tlpLeftBottom.Controls.Add(Me.btnReset, 1, 0)
        Me.tlpLeftBottom.Controls.Add(Me.btnClearAll, 0, 0)
        Me.tlpLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLeftBottom.Location = New System.Drawing.Point(1, 550)
        Me.tlpLeftBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLeftBottom.Name = "tlpLeftBottom"
        Me.tlpLeftBottom.RowCount = 2
        Me.tlpLeftBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpLeftBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpLeftBottom.Size = New System.Drawing.Size(198, 50)
        Me.tlpLeftBottom.TabIndex = 1
        '
        'btnHalt
        '
        Me.btnHalt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHalt.Location = New System.Drawing.Point(134, 27)
        Me.btnHalt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHalt.Name = "btnHalt"
        Me.btnHalt.Size = New System.Drawing.Size(64, 21)
        Me.btnHalt.TabIndex = 5
        Me.btnHalt.Text = "Halt"
        Me.btnHalt.UseVisualStyleBackColor = True
        '
        'btnStep
        '
        Me.btnStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStep.Location = New System.Drawing.Point(68, 27)
        Me.btnStep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(62, 21)
        Me.btnStep.TabIndex = 4
        Me.btnStep.Text = "Step"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'btnSlow
        '
        Me.btnSlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSlow.Location = New System.Drawing.Point(2, 27)
        Me.btnSlow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSlow.Name = "btnSlow"
        Me.btnSlow.Size = New System.Drawing.Size(62, 21)
        Me.btnSlow.TabIndex = 3
        Me.btnSlow.Text = "Slow"
        Me.btnSlow.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRun.Location = New System.Drawing.Point(134, 2)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(64, 21)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(68, 2)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(62, 21)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearAll.Location = New System.Drawing.Point(2, 2)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(62, 21)
        Me.btnClearAll.TabIndex = 0
        Me.btnClearAll.Text = "Clear"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'tlpCode
        '
        Me.tlpCode.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpCode.ColumnCount = 6
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpCode.Controls.Add(Me.rtbCommands1, 1, 0)
        Me.tlpCode.Controls.Add(Me.rtbCommands2, 3, 0)
        Me.tlpCode.Controls.Add(Me.rtbCommands3, 5, 0)
        Me.tlpCode.Controls.Add(Me.lblCommands1, 0, 0)
        Me.tlpCode.Controls.Add(Me.lblCommands2, 2, 0)
        Me.tlpCode.Controls.Add(Me.lblCommands3, 4, 0)
        Me.tlpCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCode.Location = New System.Drawing.Point(1, 1)
        Me.tlpCode.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCode.Name = "tlpCode"
        Me.tlpCode.RowCount = 1
        Me.tlpCode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCode.Size = New System.Drawing.Size(198, 548)
        Me.tlpCode.TabIndex = 2
        '
        'rtbCommands1
        '
        Me.rtbCommands1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCommands1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbCommands1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCommands1.Location = New System.Drawing.Point(33, 1)
        Me.rtbCommands1.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbCommands1.MaxLength = 200
        Me.rtbCommands1.Name = "rtbCommands1"
        Me.rtbCommands1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbCommands1.Size = New System.Drawing.Size(31, 546)
        Me.rtbCommands1.TabIndex = 3
        Me.rtbCommands1.Text = "507" & Global.Microsoft.VisualBasic.ChrW(10) & "108" & Global.Microsoft.VisualBasic.ChrW(10) & "901" & Global.Microsoft.VisualBasic.ChrW(10) & "399" & Global.Microsoft.VisualBasic.ChrW(10) & "902" & Global.Microsoft.VisualBasic.ChrW(10) & "702" & Global.Microsoft.VisualBasic.ChrW(10) & "000" & Global.Microsoft.VisualBasic.ChrW(10) & "003" & Global.Microsoft.VisualBasic.ChrW(10) & "005"
        Me.rtbCommands1.WordWrap = False
        '
        'rtbCommands2
        '
        Me.rtbCommands2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCommands2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbCommands2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCommands2.Location = New System.Drawing.Point(97, 1)
        Me.rtbCommands2.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbCommands2.MaxLength = 200
        Me.rtbCommands2.Name = "rtbCommands2"
        Me.rtbCommands2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbCommands2.Size = New System.Drawing.Size(31, 546)
        Me.rtbCommands2.TabIndex = 4
        Me.rtbCommands2.Text = ""
        Me.rtbCommands2.WordWrap = False
        '
        'rtbCommands3
        '
        Me.rtbCommands3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCommands3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbCommands3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCommands3.Location = New System.Drawing.Point(161, 1)
        Me.rtbCommands3.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbCommands3.MaxLength = 200
        Me.rtbCommands3.Name = "rtbCommands3"
        Me.rtbCommands3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbCommands3.Size = New System.Drawing.Size(36, 546)
        Me.rtbCommands3.TabIndex = 5
        Me.rtbCommands3.Text = ""
        Me.rtbCommands3.WordWrap = False
        '
        'lblCommands1
        '
        Me.lblCommands1.AutoSize = True
        Me.lblCommands1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommands1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommands1.Location = New System.Drawing.Point(1, 1)
        Me.lblCommands1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCommands1.Name = "lblCommands1"
        Me.lblCommands1.Size = New System.Drawing.Size(31, 546)
        Me.lblCommands1.TabIndex = 6
        Me.lblCommands1.Text = "00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "02" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "03" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "04" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "05" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "06" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "07" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "09" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "11" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "13" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "14" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "17" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "18" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "19" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & _
            "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "23" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "24" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "26" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "27" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "28" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "29" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "31" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "32" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "33"
        Me.lblCommands1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCommands2
        '
        Me.lblCommands2.AutoSize = True
        Me.lblCommands2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommands2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommands2.Location = New System.Drawing.Point(65, 1)
        Me.lblCommands2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCommands2.Name = "lblCommands2"
        Me.lblCommands2.Size = New System.Drawing.Size(31, 546)
        Me.lblCommands2.TabIndex = 7
        Me.lblCommands2.Text = "34" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "35" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "36" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "37" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "38" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "39" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "40" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "41" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "42" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "43" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "44" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "45" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "46" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "47" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "48" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "49" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "51" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "52" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "53" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & _
            "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "55" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "56" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "57" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "58" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "59" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "60" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "61" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "62" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "63" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "64" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "65" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "66" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "67"
        Me.lblCommands2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCommands3
        '
        Me.lblCommands3.AutoSize = True
        Me.lblCommands3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommands3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommands3.Location = New System.Drawing.Point(129, 1)
        Me.lblCommands3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCommands3.Name = "lblCommands3"
        Me.lblCommands3.Size = New System.Drawing.Size(31, 546)
        Me.lblCommands3.TabIndex = 8
        Me.lblCommands3.Text = "68" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "69" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "70" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "71" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "72" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "73" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "74" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "75" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "76" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "77" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "78" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "79" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "80" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "81" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "82" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "83" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "84" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "85" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "86" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "87" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & _
            "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "89" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "91" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "92" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "93" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "94" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "96" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "97" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "98" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "99"
        Me.lblCommands3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 601)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(628, 639)
        Me.Name = "Form"
        Me.Text = "Little Man Computer"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpRight.ResumeLayout(False)
        Me.tlpRight.PerformLayout()
        Me.tlpRightBottom.ResumeLayout(False)
        Me.tlpRightBottom.PerformLayout()
        Me.tlpRightTop.ResumeLayout(False)
        Me.tlpRightTop.PerformLayout()
        Me.tlpLeft.ResumeLayout(False)
        Me.tlpLeftBottom.ResumeLayout(False)
        Me.tlpCode.ResumeLayout(False)
        Me.tlpCode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpLeft As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRightTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMesssage As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCompile As System.Windows.Forms.Button
    Friend WithEvents btnClearMessage As System.Windows.Forms.Button
    Friend WithEvents tlpLeftBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnHalt As System.Windows.Forms.Button
    Friend WithEvents btnStep As System.Windows.Forms.Button
    Friend WithEvents btnSlow As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tlpRightBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtOutbox As System.Windows.Forms.TextBox
    Friend WithEvents txtMEMData As System.Windows.Forms.TextBox
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents txtInbox As System.Windows.Forms.TextBox
    Friend WithEvents txtMEMAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAccumulator As System.Windows.Forms.TextBox
    Friend WithEvents lblAccumulator As System.Windows.Forms.Label
    Friend WithEvents lblOutbox As System.Windows.Forms.Label
    Friend WithEvents lblMEMData As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents lblInbox As System.Windows.Forms.Label
    Friend WithEvents lblMEMAddress As System.Windows.Forms.Label
    Friend WithEvents btnInboxSubmit As System.Windows.Forms.Button
    Friend WithEvents llbLoadProject As System.Windows.Forms.LinkLabel
    Friend WithEvents tlpCode As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rtbCommands1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCommands2 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCommands3 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCommands1 As System.Windows.Forms.Label
    Friend WithEvents lblCommands2 As System.Windows.Forms.Label
    Friend WithEvents lblCommands3 As System.Windows.Forms.Label

End Class
