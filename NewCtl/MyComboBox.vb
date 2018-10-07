Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class MyComboBox
    Public Property DataSouce As BindingSource
        Get
            Return ComboList.DataSource
        End Get
        Set(value As BindingSource)
            ComboList.DataSource = value
        End Set
    End Property


    Public Property DisplayMember As String
        Get
            Return ComboList.DisplayMember
        End Get
        Set(value As String)
            ComboList.DisplayMember = value
        End Set
    End Property
    Public Property ValueMember As String
        Get
            Return ComboList.ValueMember
        End Get
        Set(value As String)
            ComboList.ValueMember = value

        End Set
    End Property
    Public Overrides Property Text As String
        Get
            Return ComboList.Text
        End Get
        Set(value As String)
            ComboText.Text = value
        End Set
    End Property
    Public ReadOnly Property Value As String
        Get
            If ComboList.DataSource IsNot Nothing Then
                Return ComboList.SelectedValue
            End If
            Return vbNullString

        End Get
    End Property
    Public Property DropDown As Boolean
        Get
            Return ComboList.Visible
        End Get
        Set(value As Boolean)
            ComboList.Visible = value
        End Set
    End Property
    Public Property FilterColumnName As String
    Public Property RowMount As Integer = 3

    Private Sub ComboList_VisibleChanged(sender As Object, e As EventArgs) Handles ComboList.VisibleChanged
        If ComboList.Visible Then

            Height = RowMount * ComboText.Height + 3
            BringToFront()
        Else

            Height = ComboText.Height + 3
            SendToBack()
        End If
    End Sub

    Private Sub ComboList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboList.SelectedIndexChanged
        MyBase.OnTextChanged(e)
    End Sub
End Class
