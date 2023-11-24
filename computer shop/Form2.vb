Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine

        Me.ControlBox = False
        Label1.Text = My.Settings.Username
        Label1.ForeColor = Color.Gray
        Label2.Text = "Locked"
        Label2.ForeColor = Color.Black

        Button1.Text = "Back"
        Button2.Text = "Enter"
        Button3.Text = "OK"
        Label3.Text = "Password"



        Button3.Hide()

        If Label1.Text = "Watcher1" Then
            PictureBox1.ImageLocation = My.Settings.Picture
        ElseIf Label1.Text = "Watcher2" Then
            PictureBox1.ImageLocation = My.Settings.Picture
        ElseIf Label1.Text = "Owner" Then
            PictureBox1.ImageLocation = My.Settings.Picture


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Label1.Text = "Watcher1" And TextBox1.Text = "Watcher1" Then
            form3.Show()
            Me.Close()

        ElseIf Label1.Text = "Watcher2" And TextBox1.Text = "Watcher2" Then
            form3.Show()
            Me.Close()

        ElseIf Label1.Text = "Owner" And TextBox1.Text = "Owner" Then
            form3.Show()
            Me.Close()

        Else
            Button3.Show()
            Label2.Text = "The password is Incorrect!, Try again!"
            Label2.ForeColor = Color.Red

            Label3.Hide()
            Button2.Hide()
            TextBox1.Hide()

        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Hide()
        Label2.Text = "Locked"
        TextBox1.Show()
        Label3.Show()
        Button2.Show()
        Label2.ForeColor = Color.Black
        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub

   
End Class