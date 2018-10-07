Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“YwtDataSet.contacts”中。您可以根据需要移动或删除它。
        Me.ContactsTableAdapter.Fill(Me.YwtDataSet.contacts)
        'TODO: 这行代码将数据加载到表“YwtDataSet.customer”中。您可以根据需要移动或删除它。
        Me.CustomerTableAdapter.Fill(Me.YwtDataSet.customer)

    End Sub

    Private Sub MyComboBox1_TextChanged(sender As Object, e As EventArgs) Handles MyComboBox1.TextChanged
        TextBox1.Text = MyComboBox1.Text
        TextBox2.Text = MyComboBox1.Value
        Dim drv As DataRowView = MyComboBox1.DataSouce.Current
        drv.DataView.Sort = MyComboBox1.ValueMember
        Dim no As Integer = drv.DataView.Find(MyComboBox1.Value)
        TextBox3.Text = drv.DataView.Item(no).Item(2)
        ' Dim no As Integer = MyComboBox1.DataSouce.

        ConBindingSource.Filter = "CustomerId='" & MyComboBox1.Value & "'"
        MyComboBox2.DataSouce = ConBindingSource
        MyComboBox2.DisplayMember = "ContactsName"
        MyComboBox2.ValueMember = "Id"

    End Sub
End Class