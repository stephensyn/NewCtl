<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyComboBox
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboText = New System.Windows.Forms.TextBox()
        Me.ComboList = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.NewCtl.My.Resources.Resources.down48
        Me.PictureBox1.Location = New System.Drawing.Point(140, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComboText
        '
        Me.ComboText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboText.Location = New System.Drawing.Point(0, 0)
        Me.ComboText.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboText.Name = "ComboText"
        Me.ComboText.Size = New System.Drawing.Size(141, 21)
        Me.ComboText.TabIndex = 1
        '
        'ComboList
        '
        Me.ComboList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboList.FormattingEnabled = True
        Me.ComboList.ItemHeight = 12
        Me.ComboList.Location = New System.Drawing.Point(0, 20)
        Me.ComboList.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboList.Name = "ComboList"
        Me.ComboList.Size = New System.Drawing.Size(161, 4)
        Me.ComboList.TabIndex = 2
        Me.ComboList.Visible = False
        '
        'MyComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboList)
        Me.Controls.Add(Me.ComboText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MyComboBox"
        Me.Size = New System.Drawing.Size(161, 22)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboText As TextBox
    Friend WithEvents ComboList As ListBox
End Class
