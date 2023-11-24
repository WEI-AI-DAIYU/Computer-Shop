Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Me.ControlBox = False
        Label1.Text = "Watcher1"
        Label2.Text = "Watcher2"
        Label3.Text = "Owner"
        Button1.Text = "Exit"


        PictureBox1.ImageLocation = "C:\Users\USER\Documents\computer shop final\computer shop final\Resources\User.png"
        PictureBox2.ImageLocation = "C:\Users\USER\Documents\computer shop final\computer shop final\Resources\User.png"
        PictureBox3.ImageLocation = "C:\Users\USER\Documents\computer shop final\computer shop final\Resources\User.png"
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        My.Settings.Picture = PictureBox1.ImageLocation
        My.Settings.Username = Label1.Text


        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        My.Settings.Picture = PictureBox2.ImageLocation
        My.Settings.Username = Label2.Text


        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        My.Settings.Picture = PictureBox3.ImageLocation
        My.Settings.Username = Label3.Text


        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
