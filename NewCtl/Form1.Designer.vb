<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.components = New System.ComponentModel.Container()
        Me.CusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YwtDataSet = New NewCtl.ywtDataSet()
        Me.CustomerTableAdapter = New NewCtl.ywtDataSetTableAdapters.customerTableAdapter()
        Me.ConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsTableAdapter = New NewCtl.ywtDataSetTableAdapters.contactsTableAdapter()
        Me.MyComboBox1 = New NewCtl.MyComboBox()
        Me.MyComboBox2 = New NewCtl.MyComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CusBindingSource
        '
        Me.CusBindingSource.DataMember = "customer"
        Me.CusBindingSource.DataSource = Me.YwtDataSet
        '
        'YwtDataSet
        '
        Me.YwtDataSet.DataSetName = "ywtDataSet"
        Me.YwtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ConBindingSource
        '
        Me.ConBindingSource.DataMember = "contacts"
        Me.ConBindingSource.DataSource = Me.YwtDataSet
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'MyComboBox1
        '
        Me.MyComboBox1.DataSouce = Me.CusBindingSource
        Me.MyComboBox1.DisplayMember = "CusName"
        Me.MyComboBox1.DropDown = True
        Me.MyComboBox1.FilterColumnName = Nothing
        Me.MyComboBox1.Location = New System.Drawing.Point(30, 37)
        Me.MyComboBox1.Name = "MyComboBox1"
        Me.MyComboBox1.RowMount = 5
        Me.MyComboBox1.Size = New System.Drawing.Size(276, 108)
        Me.MyComboBox1.TabIndex = 0
        Me.MyComboBox1.ValueMember = "Id"
        '
        'MyComboBox2
        '
        Me.MyComboBox2.DataSouce = Nothing
        Me.MyComboBox2.DisplayMember = " "
        Me.MyComboBox2.DropDown = True
        Me.MyComboBox2.FilterColumnName = Nothing
        Me.MyComboBox2.Location = New System.Drawing.Point(442, 39)
        Me.MyComboBox2.Name = "MyComboBox2"
        Me.MyComboBox2.RowMount = 5
        Me.MyComboBox2.Size = New System.Drawing.Size(161, 108)
        Me.MyComboBox2.TabIndex = 1
        Me.MyComboBox2.ValueMember = " "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 21)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(30, 233)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(91, 21)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(30, 304)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(276, 21)
        Me.TextBox3.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 362)
        Me.Controls.Add(Me.MyComboBox1)
        Me.Controls.Add(Me.MyComboBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YwtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CusBindingSource As BindingSource
    Friend WithEvents YwtDataSet As ywtDataSet
    Friend WithEvents CustomerTableAdapter As ywtDataSetTableAdapters.customerTableAdapter
    Friend WithEvents ConBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As ywtDataSetTableAdapters.contactsTableAdapter
    Friend WithEvents MyComboBox1 As MyComboBox
    Friend WithEvents MyComboBox2 As MyComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
