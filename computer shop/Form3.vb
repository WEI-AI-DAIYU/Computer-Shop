Imports System.Data.DataTable

Public Class Form3
    Dim table As New DataTable("Table")
    Dim index As Integer
    Dim miliSeconds As Integer = 0, seconds As Integer = 0, minutes As Integer = 0

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label12.Text = "0"
        Label11.Text = "."
        Label10.Text = "."
        Label9.Text = "."
        Label8.Text = "."

        ' PC Forms Hide
        Form28.Hide()
        Form27.Hide()
        Form26.Hide()
        Form25.Hide()
        Form24.Hide()
        Form23.Hide()
        Form22.Hide()
        Form21.Hide()
        Form20.Hide()
        Form19.Hide()
        Form18.Hide()
        Form17.Hide()
        Form16.Hide()
        Form15.Hide()
        Form14.Hide()
        Form13.Hide()
        Form12.Hide()
        Form11.Hide()
        Form10.Hide()
        Form9.Hide()
        Form8.Hide()
        Form7.Hide()
        Form6.Hide()
        Form5.Hide()
        Form4.Hide()



        ' ListBox
        ListBox1.Hide()
        ListBox1.Items.Add("PC 1")
        ListBox1.Items.Add("PC 2")
        ListBox1.Items.Add("PC 3")
        ListBox1.Items.Add("PC 4")
        ListBox1.Items.Add("PC 5")
        ListBox1.Items.Add("PC 6")
        ListBox1.Items.Add("PC 7")
        ListBox1.Items.Add("PC 8")
        ListBox1.Items.Add("PC 9")
        ListBox1.Items.Add("PC 10")
        ListBox1.Items.Add("PC 11")
        ListBox1.Items.Add("PC 12")
        ListBox1.Items.Add("PC 13")
        ListBox1.Items.Add("PC 14")
        ListBox1.Items.Add("PC 15")
        ListBox1.Items.Add("PC 16")
        ListBox1.Items.Add("PC 17")
        ListBox1.Items.Add("PC 18")
        ListBox1.Items.Add("PC 19")
        ListBox1.Items.Add("PC 20")
        ListBox1.Items.Add("PC 21")
        ListBox1.Items.Add("PC 22")
        ListBox1.Items.Add("PC 23")
        ListBox1.Items.Add("PC 24")
        ListBox1.Items.Add("PC 25")

        TableLayoutPanel1.Hide()

        DataGridView1.Hide()



        Button2.Text = "Log out"
        Button1.Text = "Terminal"
        Button3.Text = "Income"
        Button4.Text = "Other Services"

        GroupBox2.Text = "Time"
        Label1.Text = "Today is "
        Label2.Text = "Date :"
        Label3.Text = "Time :"

        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black

        Label6.Text = My.Settings.Username


        table.Columns.Add("Terminal", Type.GetType("System.String"))
        table.Columns.Add("Start", Type.GetType("System.String"))
        table.Columns.Add("Stop", Type.GetType("System.String"))
        table.Columns.Add("Rate type", Type.GetType("System.String"))
        table.Columns.Add("Time(minutes)", Type.GetType("System.String"))
        table.Columns.Add("PrepaidPH", Type.GetType("System.String"))

        '  table.Rows.Add("dede", "0", "0", "0", " 0   :   0   :   0", 0)
        ' table.Rows.Add("PC 2", "0", "0", "0", " 0   :   0   :   0", 0)
        ' table.Rows.Add("PC 3", "", "", "", " 0   :   0   :   0", 0)
        '        table.Rows.Add("PC 4", "", "", "", " 0   :   0   :   0", 0)
        '       table.Rows.Add("PC 5", "", "", "", " 0   :   0   :   0", 0)
        '      table.Rows.Add("PC 6", "", "", "", " 0   :   0   :   0", 0)
        '     table.Rows.Add("PC 7", "", "", "", " 0   :   0   :   0", 0)
        '    table.Rows.Add("PC 8", "", "", "", " 0   :   0   :   0", 0)
        '   table.Rows.Add("PC 9", "", "", "", " 0   :   0   :   0", 0)
        '  table.Rows.Add("PC 10", "", "", "", " 0   :   0   :   0", 0)
        ' table.Rows.Add("PC 11", "", "", "", " 0   :   0   :   0", 0)
        'table.Rows.Add("PC 12", "", "", "", " 0   :   0   :   0", 0)
        '        table.Rows.Add("PC 13", "", "", "", " 0   :   0   :   0", 0)
        '       table.Rows.Add("PC 14", "", "", "", " 0   :   0   :   0", 0)
        '      table.Rows.Add("PC 15", "", "", "", " 0   :   0   :   0", 0)
        '     table.Rows.Add("PC 16", "", "", "", " 0   :   0   :   0", 0)
        '    table.Rows.Add("PC 17", "", "", "", " 0   :   0   :   0", 0)
        '   table.Rows.Add("PC 18", "", "", "", " 0   :   0   :   0", 0)
        '  table.Rows.Add("PC 19", "", "", "", " 0   :   0   :   0", 0)
        ' table.Rows.Add("PC 20", "", "", "", " 0   :   0   :   0", 0)
        'table.Rows.Add("PC 21", "", "", "", " 0   :   0   :   0", 0)
        '        table.Rows.Add("PC 22", "", "", "", " 0   :   0   :   0", 0)
        '       table.Rows.Add("PC 23", "", "", "", " 0   :   0   :   0", 0)
        '      table.Rows.Add("PC 24", "", "", "", " 0   :   0   :   0", 0)
        '     table.Rows.Add("PC 25", "", "", "", " 0   :   0   :   0", 0)

        'DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("If you press OK," & vbLf & "all of the open PC will automatically Stop!!" & vbLf & vbLf & "Do you still want to Continue?", MsgBoxStyle.OkCancel)
        If ask = MsgBoxResult.Ok Then
            Form4.Show()
            Form5.Show()
            Form6.Show()
            Form7.Show()
            Form8.Show()
            Form9.Show()
            Form10.Show()
            Form11.Show()
            Form12.Show()
            Form13.Show()
            Form14.Show()
            Form15.Show()
            Form16.Show()
            Form17.Show()
            Form18.Show()
            Form19.Show()
            Form20.Show()
            Form21.Show()
            Form22.Show()
            Form23.Show()
            Form24.Show()
            Form25.Show()
            Form26.Show()
            Form27.Show()
            Form28.Show()

            Form4.Button2.PerformClick()
            Form5.Button2.PerformClick()
            Form6.Button2.PerformClick()
            Form7.Button2.PerformClick()
            Form8.Button2.PerformClick()
            Form9.Button2.PerformClick()
            Form10.Button2.PerformClick()
            Form11.Button2.PerformClick()
            Form12.Button2.PerformClick()
            Form13.Button2.PerformClick()
            Form14.Button2.PerformClick()
            Form15.Button2.PerformClick()
            Form16.Button2.PerformClick()
            Form17.Button2.PerformClick()
            Form18.Button2.PerformClick()
            Form19.Button2.PerformClick()
            Form20.Button2.PerformClick()
            Form21.Button2.PerformClick()
            Form22.Button2.PerformClick()
            Form23.Button2.PerformClick()
            Form24.Button2.PerformClick()
            Form25.Button2.PerformClick()
            Form26.Button2.PerformClick()
            Form27.Button2.PerformClick()
            Form28.Button2.PerformClick()


            Form4.Button3.PerformClick()
            Form5.Button3.PerformClick()
            Form6.Button3.PerformClick()
            Form7.Button3.PerformClick()
            Form8.Button3.PerformClick()
            Form9.Button3.PerformClick()
            Form10.Button3.PerformClick()
            Form11.Button3.PerformClick()
            Form12.Button3.PerformClick()
            Form13.Button3.PerformClick()
            Form14.Button3.PerformClick()
            Form15.Button3.PerformClick()
            Form16.Button3.PerformClick()
            Form17.Button3.PerformClick()
            Form18.Button3.PerformClick()
            Form19.Button3.PerformClick()
            Form20.Button3.PerformClick()
            Form21.Button3.PerformClick()
            Form22.Button3.PerformClick()
            Form23.Button3.PerformClick()
            Form24.Button3.PerformClick()
            Form25.Button3.PerformClick()
            Form26.Button3.PerformClick()
            Form27.Button3.PerformClick()
            Form28.Button3.PerformClick()

            Me.Close()
            Form1.Show()

            Form4.Hide()
            Form5.Hide()
            Form6.Hide()
            Form7.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Show()
        DataGridView1.Show()
        TableLayoutPanel1.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay

        My.Settings.Hours = Label5.Text

        Label4.Text = Date.Now.ToString("MM/dd/yyyy")
    End Sub 

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "PC 1" Then
            Form4.TextBox1.Text = PC1.Text
            Form4.Show()
            Form5.Hide()
            Form6.Hide()
            Form7.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 2" Then
            Form5.TextBox1.Text = PC2.Text
            Form5.Show()
            Form4.Hide()
            Form6.Hide()
            Form7.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 3" Then
            Form6.TextBox1.Text = PC3.Text
            Form6.Show()
            Form5.Hide()
            Form4.Hide()
            Form7.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 4" Then
            Form7.TextBox1.Text = PC4.Text
            Form7.Show()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 5" Then
            Form8.TextBox1.Text = PC5.Text
            Form8.Show()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 6" Then
            Form9.TextBox1.Text = PC6.Text
            Form9.Show()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 7" Then
            Form10.TextBox1.Text = PC7.Text
            Form10.Show()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 8" Then
            Form11.TextBox1.Text = PC8.Text
            Form11.Show()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 9" Then
            Form12.TextBox1.Text = PC9.Text
            Form12.Show()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 10" Then
            Form13.TextBox1.Text = PC10.Text
            Form13.Show()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 11" Then
            Form14.TextBox1.Text = PC11.Text
            Form14.Show()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 12" Then
            Form15.TextBox1.Text = PC12.Text
            Form15.Show()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 13" Then
            Form16.TextBox1.Text = PC13.Text
            Form16.Show()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 14" Then
            Form17.TextBox1.Text = PC14.Text
            Form17.Show()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 15" Then
            Form18.TextBox1.Text = PC15.Text
            Form18.Show()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 16" Then
            Form19.TextBox1.Text = PC16.Text
            Form19.Show()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form20.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 17" Then
            Form20.TextBox1.Text = PC17.Text
            Form20.Show()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form21.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 18" Then
            Form21.TextBox1.Text = PC18.Text
            Form21.Show()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form22.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 19" Then
            Form22.TextBox1.Text = PC19.Text
            Form22.Show()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form23.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 20" Then
            Form23.TextBox1.Text = PC20.Text
            Form23.Show()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form24.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 21" Then
            Form24.TextBox1.Text = PC21.Text
            Form24.Show()
            Form23.Hide()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form25.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 22" Then
            Form25.TextBox1.Text = PC22.Text
            Form25.Show()
            Form24.Hide()
            Form23.Hide()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form26.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 23" Then
            Form26.TextBox1.Text = PC23.Text
            Form26.Show()
            Form25.Hide()
            Form24.Hide()
            Form23.Hide()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form27.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 24" Then
            Form27.TextBox1.Text = PC24.Text
            Form27.Show()
            Form26.Hide()
            Form25.Hide()
            Form24.Hide()
            Form23.Hide()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form28.Hide()

        ElseIf ListBox1.SelectedItem = "PC 25" Then
            Form28.TextBox1.Text = PC25.Text
            Form28.Show()
            Form27.Hide()
            Form26.Hide()
            Form25.Hide()
            Form24.Hide()
            Form23.Hide()
            Form22.Hide()
            Form21.Hide()
            Form20.Hide()
            Form19.Hide()
            Form18.Hide()
            Form17.Hide()
            Form16.Hide()
            Form15.Hide()
            Form14.Hide()
            Form13.Hide()
            Form12.Hide()
            Form11.Hide()
            Form10.Hide()
            Form9.Hide()
            Form8.Hide()
            Form7.Hide()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()

        End If
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form28.Hide()
        Form27.Hide()
        Form26.Hide()
        Form25.Hide()
        Form24.Hide()
        Form23.Hide()
        Form22.Hide()
        Form21.Hide()
        Form20.Hide()
        Form19.Hide()
        Form18.Hide()
        Form17.Hide()
        Form16.Hide()
        Form15.Hide()
        Form14.Hide()
        Form13.Hide()
        Form12.Hide()
        Form11.Hide()
        Form10.Hide()
        Form9.Hide()
        Form8.Hide()
        Form7.Hide()
        Form6.Hide()
        Form5.Hide()
        Form4.Hide()

        data.Show()
        Me.Hide()



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form29.Show()

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click

    End Sub

    Private Sub Label156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label156.Click

    End Sub

    Private Sub Label155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label155.Click

    End Sub

    Private Sub Label154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label154.Click

    End Sub

    Private Sub Label153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label153.Click

    End Sub

    Private Sub Label152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label152.Click

    End Sub

    Private Sub Label150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label150.Click

    End Sub

    Private Sub Label149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label149.Click

    End Sub

    Private Sub PC24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC24.Click

    End Sub

    Private Sub Label142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label142.Click

    End Sub

    Private Sub Label140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label140.Click

    End Sub

    Private Sub PC23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC23.Click

    End Sub

    Private Sub Label138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label138.Click

    End Sub

    Private Sub Label137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label137.Click

    End Sub

    Private Sub Label136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label136.Click

    End Sub

    Private Sub Label135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label135.Click

    End Sub

    Private Sub Label134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label134.Click

    End Sub

    Private Sub PC22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC22.Click

    End Sub

    Private Sub Label132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label132.Click

    End Sub

    Private Sub Label131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label131.Click

    End Sub

    Private Sub Label130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label130.Click

    End Sub

    Private Sub Label129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label129.Click

    End Sub

    Private Sub Label128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label128.Click

    End Sub

    Private Sub PC21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC21.Click

    End Sub

    Private Sub Label126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label126.Click

    End Sub

    Private Sub Label125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label125.Click

    End Sub

    Private Sub Label124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label124.Click

    End Sub

    Private Sub Label123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label123.Click

    End Sub

    Private Sub Label122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label122.Click

    End Sub

    Private Sub PC20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC20.Click

    End Sub

    Private Sub Label120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label120.Click

    End Sub

    Private Sub Label119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label119.Click

    End Sub

    Private Sub Label118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label118.Click

    End Sub

    Private Sub Label117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label117.Click

    End Sub

    Private Sub Label116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label116.Click

    End Sub

    Private Sub PC19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC19.Click

    End Sub

    Private Sub Label114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label114.Click

    End Sub

    Private Sub Label113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label113.Click

    End Sub

    Private Sub Label112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label112.Click

    End Sub

    Private Sub Label111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label111.Click

    End Sub

    Private Sub Label110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label110.Click

    End Sub

    Private Sub PC18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC18.Click

    End Sub

    Private Sub Label108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label108.Click

    End Sub

    Private Sub Label107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label107.Click

    End Sub

    Private Sub Label106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label106.Click

    End Sub

    Private Sub Label105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label105.Click

    End Sub

    Private Sub Label104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label104.Click

    End Sub

    Private Sub PC17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC17.Click

    End Sub

    Private Sub Label102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label102.Click

    End Sub

    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click

    End Sub

    Private Sub Label100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click

    End Sub

    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click

    End Sub

    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click

    End Sub

    Private Sub PC16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC16.Click

    End Sub

    Private Sub Label96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label96.Click

    End Sub

    Private Sub Label95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label95.Click

    End Sub

    Private Sub Label94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label94.Click

    End Sub

    Private Sub Label93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label93.Click

    End Sub

    Private Sub Label92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label92.Click

    End Sub

    Private Sub PC15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC15.Click

    End Sub

    Private Sub Label90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label90.Click

    End Sub

    Private Sub Label89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label89.Click

    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click

    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click

    End Sub

    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click

    End Sub

    Private Sub PC14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC14.Click

    End Sub

    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click

    End Sub

    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click

    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click

    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click

    End Sub

    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click

    End Sub

    Private Sub PC13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC13.Click

    End Sub

    Private Sub Label78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label78.Click

    End Sub

    Private Sub Label77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label77.Click

    End Sub

    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click

    End Sub

    Private Sub Label75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label75.Click

    End Sub

    Private Sub Label74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label74.Click

    End Sub

    Private Sub PC12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC12.Click

    End Sub

    Private Sub Label72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label72.Click

    End Sub

    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click

    End Sub

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click

    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label69.Click

    End Sub

    Private Sub Label68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label68.Click

    End Sub

    Private Sub PC11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC11.Click

    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label66.Click

    End Sub

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.Click

    End Sub

    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click

    End Sub

    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click

    End Sub

    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click

    End Sub

    Private Sub PC10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC10.Click

    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click

    End Sub

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click

    End Sub

    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click

    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click

    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click

    End Sub

    Private Sub PC9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC9.Click

    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click

    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click

    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click

    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click

    End Sub

    Private Sub PC8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC8.Click

    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click

    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub PC7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC7.Click

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click

    End Sub

    Private Sub PC6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC6.Click

    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub PC5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC5.Click

    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub PC4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC4.Click

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub PC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC3.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub PC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC2.Click

    End Sub

    Private Sub Label141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label141.Click

    End Sub

    Private Sub Label143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label143.Click

    End Sub

    Private Sub Label144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label144.Click

    End Sub

    Private Sub Label146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label146.Click

    End Sub

    Private Sub Label147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label147.Click

    End Sub

    Private Sub Label148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label148.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC1.Click

    End Sub

    Private Sub PC25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC25.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class