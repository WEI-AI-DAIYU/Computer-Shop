
Public Class Form19
    Dim running As Boolean = False
    Dim hr As Integer = 0, min As Integer = 0, sec As Integer = 0
    Dim seconds As Integer = 0, minutes As Integer = 0, hours As Integer = 0
    Dim php As Integer = 0, cents As Integer = 0, tic As Integer = 0


    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()


        TextBox6.Hide()
        ComboBox2.Hide()
        ComboBox3.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "PC16" Then
            Form3.PC16.ForeColor = Color.Green
            Form3.Label98.ForeColor = Color.Green
            Form3.Label100.ForeColor = Color.Green
            Form3.Label102.ForeColor = Color.Green
            Button4.Enabled = False

            TextBox6.Enabled = False
            TextBox2.Text = My.Settings.Hours
            Form3.Label98.Text = TextBox2.Text



            ' Regular
            If ComboBox1.Text = "Regular" And ComboBox2.Text = "25" Then
                Timer2.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "50" Then
                Timer3.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "75" Then
                Timer4.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "100" Then
                Timer5.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "125" Then
                Timer6.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "150" Then
                Timer7.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "175" Then
                Timer8.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "200" Then
                Timer9.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "225" Then
                Timer10.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "250" Then
                Timer11.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "275" Then
                Timer12.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "300" Then
                Timer13.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "325" Then
                Timer14.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "350" Then
                Timer15.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "375" Then
                Timer16.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "400" Then
                Timer17.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "425" Then
                Timer18.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "450" Then
                Timer19.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "475" Then
                Timer20.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "500" Then
                Timer21.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "525" Then
                Timer22.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "550" Then
                Timer23.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "575" Then
                Timer24.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text
            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "600" Then
                Timer25.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Form3.Label102.Text = ComboBox2.Text


                ' open time
            ElseIf ComboBox1.Text = "Open time" Then
                Timer1.Enabled = True
                Timer1.Start()
                Timer26.Enabled = True

                Timer26.Start()

                Form3.Label101.Text = TextBox5.Text
                Form3.Label102.Text = TextBox6.Text

                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False

                ' Promo

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "75" Then
                Timer4.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "150" Then
                Timer7.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "225" Then
                Timer10.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "300" Then
                Timer13.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "375" Then
                Timer16.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "450" Then
                Timer19.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "525" Then
                Timer22.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "600" Then
                Timer25.Start()
                Form3.Label101.Text = TextBox6.Text
                Button2.Enabled = True
                Button1.Enabled = False
                Form3.Label100.Text = ComboBox1.Text
                ComboBox1.Enabled = False
                ComboBox3.Enabled = False
                Form3.Label102.Text = ComboBox3.Text


            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Open time

        My.Settings.Time = Timer1.ToString


        seconds += 1

        If seconds = 60 Then
            seconds = 0

            minutes += 1
            If minutes = 60 Then
                minutes = 0
                hours += 1



            End If
        End If


        TextBox5.Text = hours & " :" & minutes & " :" & seconds

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Form3.Label6.Text = "Watcher1" Then
            Form3.PC16.ForeColor = Color.Red
            Form3.Label98.ForeColor = Color.Red
            Form3.Label99.ForeColor = Color.Red
            Form3.Label100.ForeColor = Color.Red
            Form3.Label101.ForeColor = Color.Red
            Form3.Label102.ForeColor = Color.Red
            Button4.Enabled = False


            ' Regular
            If ComboBox1.Text = "Regular" And ComboBox2.Text = "25" Then
                Timer2.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "50" Then
                Timer3.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "100" Then
                Timer5.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "125" Then
                Timer6.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "175" Then
                Timer8.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "200" Then
                Timer9.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "250" Then
                Timer11.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "275" Then
                Timer12.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "325" Then
                Timer14.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "350" Then
                Timer15.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "400" Then
                Timer17.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "425" Then
                Timer18.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "475" Then
                Timer20.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "500" Then
                Timer21.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "550" Then
                Timer23.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "575" Then
                Timer24.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)




                ' open time
            ElseIf ComboBox1.Text = "Open time" Then
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Timer1.Stop()
                Timer1.Enabled = False
                Timer26.Stop()
                Timer26.Enabled = False

                Form3.Label101.Text = TextBox5.Text
                Form3.Label102.Text = TextBox6.Text


                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)



                ' Promo
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView1.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)



            End If
            'WATCHER2

        ElseIf Form3.Label6.Text = "Watcher2" Then
            Form3.PC16.ForeColor = Color.Red
            Form3.Label98.ForeColor = Color.Red
            Form3.Label99.ForeColor = Color.Red
            Form3.Label100.ForeColor = Color.Red
            Form3.Label101.ForeColor = Color.Red
            Form3.Label102.ForeColor = Color.Red
            Button4.Enabled = False


            ' Regular
            If ComboBox1.Text = "Regular" And ComboBox2.Text = "25" Then
                Timer2.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "50" Then
                Timer3.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "100" Then
                Timer5.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "125" Then
                Timer6.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "175" Then
                Timer8.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "200" Then
                Timer9.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "250" Then
                Timer11.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "275" Then
                Timer12.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "325" Then
                Timer14.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "350" Then
                Timer15.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "400" Then
                Timer17.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "425" Then
                Timer18.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "475" Then
                Timer20.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "500" Then
                Timer21.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "550" Then
                Timer23.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "575" Then
                Timer24.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)




                ' open time
            ElseIf ComboBox1.Text = "Open time" Then
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Timer1.Stop()
                Timer1.Enabled = False
                Timer26.Stop()
                Timer26.Enabled = False

                Form3.Label101.Text = TextBox5.Text
                Form3.Label102.Text = TextBox6.Text


                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)



                ' Promo
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView2.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)






            End If
            'OWNER

        Else
            Form3.PC16.ForeColor = Color.Red
            Form3.Label98.ForeColor = Color.Red
            Form3.Label99.ForeColor = Color.Red
            Form3.Label100.ForeColor = Color.Red
            Form3.Label101.ForeColor = Color.Red
            Form3.Label102.ForeColor = Color.Red
            Button4.Enabled = False


            ' Regular
            If ComboBox1.Text = "Regular" And ComboBox2.Text = "25" Then
                Timer2.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "50" Then
                Timer3.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "100" Then
                Timer5.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "125" Then
                Timer6.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "175" Then
                Timer8.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "200" Then
                Timer9.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "250" Then
                Timer11.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "275" Then
                Timer12.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "325" Then
                Timer14.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "350" Then
                Timer15.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "400" Then
                Timer17.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "425" Then
                Timer18.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "475" Then
                Timer20.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "500" Then
                Timer21.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "550" Then
                Timer23.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "575" Then
                Timer24.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Regular" And ComboBox2.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)




                ' open time
            ElseIf ComboBox1.Text = "Open time" Then
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Timer1.Stop()
                Timer1.Enabled = False
                Timer26.Stop()
                Timer26.Enabled = False

                Form3.Label101.Text = TextBox5.Text
                Form3.Label102.Text = TextBox6.Text


                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)



                ' Promo
            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "75" Then
                Timer4.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "150" Then
                Timer7.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "225" Then
                Timer10.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "300" Then
                Timer13.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "375" Then
                Timer16.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "450" Then
                Timer19.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "525" Then
                Timer22.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)

            ElseIf ComboBox1.Text = "Promo" And ComboBox3.Text = "600" Then
                Timer25.Stop()
                Form3.Label101.Text = TextBox5.Text
                TextBox3.Text = My.Settings.Hours
                Form3.Label99.Text = TextBox3.Text
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                data.DataGridView3.Rows.Add(Form3.PC16.Text, Form3.Label4.Text, Form3.Label101.Text, Form3.Label102.Text)




            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button4.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        TextBox6.Hide()
        ComboBox2.Hide()
        ComboBox3.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()



        Form3.PC16.ForeColor = Color.Black
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox2.Text = ""
        TextBox6.Text = ""
        ComboBox3.Text = ""

        hr = 0
        min = 0
        sec = 0
        php = 0
        cents = 0
        hours = 0
        minutes = 0
        seconds = 0
        ' TextBox5.Text = hours & ":" & minutes & ":" & seconds

        Form3.Label98.Text = TextBox2.Text
        Form3.Label99.Text = TextBox3.Text
        Form3.Label100.Text = ComboBox1.Text
        Form3.Label101.Text = TextBox5.Text
        Form3.Label102.Text = ComboBox2.Text

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Regular" Then
            Label7.Show()
            ComboBox1.Enabled = False
            ComboBox2.Show()

        ElseIf ComboBox1.Text = "Open time" Then
            Button1.Enabled = True
            ComboBox1.Enabled = False
            Button4.Enabled = True
            TextBox6.Show()
            Label6.Show()
        Else
            ComboBox1.Enabled = False
            Label8.Show()
            ComboBox3.Show()


        End If
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        '  My.Settings.Time = Timer1.ToString
        ' PHP 25


        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 1 Then
                    Button2.PerformClick()
                    Timer2.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "25" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "50" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "75" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "100" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "125" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "150" Then
            Button1.Enabled = True
            Button4.Enabled = True
            ComboBox2.Enabled = False
        ElseIf ComboBox2.Text = "175" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "200" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "225" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "250" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "275" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "300" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "325" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "350" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "375" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "400" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "425" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "450" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "475" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "500" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "525" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "550" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "575" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox2.Text = "600" Then
            Button1.Enabled = True
            Button4.Enabled = True


        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ' PHP 50
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 2 Then
                    Button2.PerformClick()
                    Timer3.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 3 Then
                        Button2.PerformClick()
                        Timer4.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If
                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then

            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 4 Then
                        Button2.PerformClick()
                        Timer4.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If
                End If
            End If


        End If
        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ' PHP 100
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 4 Then
                    Button2.PerformClick()
                    Timer5.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        ' PHP 125
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 5 Then
                    Button2.PerformClick()
                    Timer6.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        ' PHP 150
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 6 Then
                        Button2.PerformClick()
                        Timer7.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 8 Then
                        Button2.PerformClick()
                        Timer7.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec

    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        ' PHP 175
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 7 Then
                    Button2.PerformClick()
                    Timer8.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        ' PHP 200
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 8 Then
                    Button2.PerformClick()
                    Timer9.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        ' PHP 225
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 9 Then
                        Button2.PerformClick()
                        Timer10.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If

        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 12 Then
                        Button2.PerformClick()
                        Timer10.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If




        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        ' PHP 250
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 10 Then
                    Button2.PerformClick()
                    Timer11.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        ' PHP 275
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 11 Then
                    Button2.PerformClick()
                    Timer12.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        ' PHP 300
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 12 Then
                        Button2.PerformClick()
                        Timer13.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 16 Then
                        Button2.PerformClick()
                        Timer13.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        ' PHP 325
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 13 Then
                    Button2.PerformClick()
                    Timer14.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        ' PHP 350
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 14 Then
                    Button2.PerformClick()
                    Timer15.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        ' PHP 375
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 15 Then
                        Button2.PerformClick()
                        Timer16.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 20 Then
                        Button2.PerformClick()
                        Timer16.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If

        End If

        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        ' PHP 400
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 16 Then
                    Button2.PerformClick()
                    Timer17.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        ' PHP 425
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 17 Then
                    Button2.PerformClick()
                    Timer18.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        ' PHP 450
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 18 Then
                        Button2.PerformClick()
                        Timer19.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 24 Then
                        Button2.PerformClick()
                        Timer19.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If


        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        ' PHP 475
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 19 Then
                    Button2.PerformClick()
                    Timer20.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer21.Tick
        ' PHP 500
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 20 Then
                    Button2.PerformClick()
                    Timer21.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer22.Tick
        ' PHP 525
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 21 Then
                        Button2.PerformClick()
                        Timer22.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 28 Then
                        Button2.PerformClick()
                        Timer22.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If

        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer23.Tick
        ' PHP 550
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 22 Then
                    Button2.PerformClick()
                    Timer23.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer24_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer24.Tick
        ' PHP 575
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
            If min = 60 Then
                min = 0
                hr = 1
                If hr = 23 Then
                    Button2.PerformClick()
                    Timer24.Stop()
                    Form3.PC16.ForeColor = Color.Red
                    Form3.Label98.ForeColor = Color.Red
                    Form3.Label99.ForeColor = Color.Red
                    Form3.Label100.ForeColor = Color.Red
                    Form3.Label101.ForeColor = Color.Red
                    Form3.Label102.ForeColor = Color.Red
                End If

            End If
        End If



        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Timer25_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer25.Tick
        ' PHP 600
        If ComboBox1.Text = "Regular" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 24 Then
                        Button2.PerformClick()
                        Timer25.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        ElseIf ComboBox1.Text = "Promo" Then
            sec += 1

            If sec = 60 Then
                sec = 0
                min += 1
                If min = 60 Then
                    min = 0
                    hr = 1
                    If hr = 32 Then
                        Button2.PerformClick()
                        Timer25.Stop()
                        Form3.PC16.ForeColor = Color.Red
                        Form3.Label98.ForeColor = Color.Red
                        Form3.Label99.ForeColor = Color.Red
                        Form3.Label100.ForeColor = Color.Red
                        Form3.Label101.ForeColor = Color.Red
                        Form3.Label102.ForeColor = Color.Red
                    End If

                End If
            End If
        End If


        TextBox5.Text = hr & ":" & min & ":" & sec
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        TextBox6.Hide()
        ComboBox2.Hide()
        ComboBox3.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()




        TextBox6.Hide()

        Button4.Enabled = False
        Button1.Enabled = False


    End Sub

    Private Sub Timer26_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer26.Tick
        ' Open time Price
        tic += 1

        If tic = 15 Then
            tic = 0
            cents += 1
            If cents = 10 Then
                cents = 0
                php += 1

            End If
        End If


        TextBox6.Text = php & "." & cents



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "75" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "150" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "225" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "300" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "375" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "450" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "525" Then
            Button1.Enabled = True
            Button4.Enabled = True
        ElseIf ComboBox3.Text = "600" Then
            Button1.Enabled = True
            Button4.Enabled = True





        End If
    End Sub
End Class