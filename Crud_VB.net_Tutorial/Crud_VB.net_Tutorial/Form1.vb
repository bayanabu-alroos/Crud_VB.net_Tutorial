Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboColor.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextDesign.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iname As String = TextItemName.Text
        Dim design As String = TextDesign.Text
        Dim color As String = ComboColor.Text
        Dim datet As String = DateTimeInsert.Text
        Dim wtype As String = ""
        If RadioAllowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "Not Allowed"
        End If
        Dim connection As New SqlConnection("Server= BAYAN\SQLEXPRESS; Database = ProgrammingDB_VB.NET; Integrated Security = true")
        connection.Open()
        Dim command As New SqlCommand("
        INSERT INTO Product_Setup_Tab
          
        VALUES
           ('" & iname & "'
           ,'" & design & "'
           ,'" & color & "'
           ,'" & datet & "'
           ,'" & wtype & "')

        ", connection)
        command.ExecuteNonQuery()
        MessageBox.Show("Successfully Inserted !")







    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextItemName.TextChanged

    End Sub
End Class
