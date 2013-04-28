<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projects))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel
        Me.tlpRight = New System.Windows.Forms.TableLayoutPanel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.txtContents = New System.Windows.Forms.TextBox
        Me.lbProjects = New System.Windows.Forms.ListBox
        Me.tlpMain.SuspendLayout()
        Me.tlpRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpRight, 1, 0)
        Me.tlpMain.Controls.Add(Me.lbProjects, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(787, 560)
        Me.tlpMain.TabIndex = 0
        '
        'tlpRight
        '
        Me.tlpRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRight.ColumnCount = 1
        Me.tlpRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRight.Controls.Add(Me.lblTitle, 0, 0)
        Me.tlpRight.Controls.Add(Me.lblCopyright, 0, 2)
        Me.tlpRight.Controls.Add(Me.txtContents, 0, 1)
        Me.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRight.Location = New System.Drawing.Point(202, 1)
        Me.tlpRight.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRight.Name = "tlpRight"
        Me.tlpRight.RowCount = 3
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpRight.Size = New System.Drawing.Size(584, 558)
        Me.tlpRight.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(2, 2)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(165, 34)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Instructions"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCopyright.Location = New System.Drawing.Point(4, 540)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(554, 14)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "This work by Matthew Consterdine is licensed under a Creative Commons Attribution" & _
            "-NonCommercial-ShareAlike 3.0 Unported License."
        '
        'txtContents
        '
        Me.txtContents.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtContents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContents.Location = New System.Drawing.Point(1, 38)
        Me.txtContents.Margin = New System.Windows.Forms.Padding(0)
        Me.txtContents.Multiline = True
        Me.txtContents.Name = "txtContents"
        Me.txtContents.ReadOnly = True
        Me.txtContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContents.Size = New System.Drawing.Size(582, 498)
        Me.txtContents.TabIndex = 3
        Me.txtContents.Text = resources.GetString("txtContents.Text")
        '
        'lbProjects
        '
        Me.lbProjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProjects.Items.AddRange(New Object() {"Input and Output", "Using Memory", "Instructions"})
        Me.lbProjects.Location = New System.Drawing.Point(1, 1)
        Me.lbProjects.Margin = New System.Windows.Forms.Padding(0)
        Me.lbProjects.Name = "lbProjects"
        Me.lbProjects.Size = New System.Drawing.Size(200, 546)
        Me.lbProjects.TabIndex = 0
        '
        'Projects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 560)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Projects"
        Me.Text = "Projects"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpRight.ResumeLayout(False)
        Me.tlpRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbProjects As System.Windows.Forms.ListBox
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents txtContents As System.Windows.Forms.TextBox
End Class
