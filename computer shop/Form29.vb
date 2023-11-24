Public Class Form29

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label11.Show()
        Label2.Show()
        Label5.Show()
        ComboBox1.Show()

        Label3.Hide()
        Label6.Hide()
        ComboBox2.Text = ""
        ComboBox2.Hide()

        ComboBox3.Text = ""
        Label6.Text = ""
        Label9.Text = ""
        ComboBox2.Enabled = False
        ComboBox1.Enabled = True
        ComboBox3.Enabled = False

        Label4.Show()
        Label7.Show()
        Label9.Show()
        Label8.Show()
        ComboBox3.Show()
        Button1.Show()
        Button2.Show()

        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label9.Text = ""



    End Sub

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = "0"
        Label6.Text = "0"
        Label7.Text = "0"
        Label9.Text = "0"

        Label2.Hide()
        Label5.Hide()
        ComboBox1.Hide()
        Label11.Hide()
        Label3.Hide()
        Label6.Hide()
        ComboBox2.Hide()
        ComboBox3.Enabled = False

        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()

        Button1.Enabled = False
        Button2.Enabled = False

        Label4.Hide()
        Label7.Hide()
        Label9.Hide()
        Label8.Hide()
        ComboBox3.Hide()
        Button1.Hide()
        Button2.Hide()
        Label10.Hide()
        Label12.Hide()




    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label11.Show()
        Label3.Show()
        Label6.Show()
        Label7.Show()
        Label9.Show()
        ComboBox2.Show()

        Label2.Hide()
        Label5.Hide()
        ComboBox1.Text = ""
        ComboBox1.Hide()

        ComboBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label9.Text = ""
        Label7.Text = ""
        ComboBox1.Enabled = False
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        Label7.Text = ""

        Label4.Show()
        Label7.Show()
        Label9.Show()
        Label8.Show()
        ComboBox3.Show()
        Button1.Show()
        Button2.Show()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Black and White text" Then
            Label5.Text = "5"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        ElseIf ComboBox1.Text = "Colored Text" Then
            Label5.Text = "7"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        ElseIf ComboBox1.Text = "Text with Pictures" Then
            Label5.Text = "10"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        ElseIf ComboBox1.Text = "Full Colored Pictures" Then
            Label5.Text = "15"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        ElseIf ComboBox1.Text = "Xerox" Then
            Label5.Text = "2"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        ElseIf ComboBox1.Text = "Scan" Then
            Label5.Text = "15"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Wallet Size (3 pcs)" Then
            Label6.Text = "15"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "3R Size (2 pcs)" Then
            Label6.Text = "20"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "4R Size" Then
            Label6.Text = "14"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "5R Size" Then
            Label6.Text = "16"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "A4 Size" Then
            Label6.Text = "35"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "RUSH I.D. (4pcs 2x2 & 4pcs 1x1)" Then
            Label6.Text = "35"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
        ElseIf ComboBox2.Text = "Photo Editing" Then
            Label6.Text = "30"
            ComboBox3.Enabled = True
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)



        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView2.Rows.Clear()
        Me.DataGridView3.Rows.Clear()

        Label2.Hide()
        Label5.Hide()
        ComboBox1.Hide()

        Label3.Hide()
        Label6.Hide()
        ComboBox2.Hide()
        ComboBox3.Enabled = False

        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()

        Button1.Enabled = False
        Button2.Enabled = False

        Label4.Hide()
        Label7.Hide()
        Label9.Hide()
        Label8.Hide()
        ComboBox3.Hide()
        Button1.Hide()
        Button2.Hide()
        Label10.Hide()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Hide()

        Me.Close()
        Form3.Show()


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged


        If ComboBox1.Enabled = True Then
            Label7.Text = ComboBox3.Text
            Label9.Text = Val(Label5.Text) * Val(Label7.Text)
            Button2.Enabled = True
            Button1.Enabled = True
        ElseIf ComboBox2.Enabled = True Then
            Label7.Text = ComboBox3.Text
            Label9.Text = Val(Label6.Text) * Val(Label7.Text)
            Button2.Enabled = True
            Button1.Enabled = True
        End If
        
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Form3.Label6.Text = "Watcher1" Then

            If ComboBox1.Enabled = True Then
                DataGridView1.Show()
                DataGridView2.Hide()
                DataGridView3.Hide()
                DataGridView1.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)
                data.DataGridView4.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)

                Dim sum As Decimal
                For Each num As DataGridViewRow In DataGridView1.Rows

                    sum += num.Cells(4).Value
                Next
                Label10.Text = sum

            ElseIf ComboBox2.Enabled = True Then
                DataGridView1.Show()
                DataGridView2.Hide()
                DataGridView3.Hide()
                DataGridView1.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)
                data.DataGridView4.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)

                Dim sum As Decimal
                For Each num As DataGridViewRow In DataGridView1.Rows

                    sum += num.Cells(4).Value
                Next
                Label10.Text = sum


            End If
        ElseIf Form3.Label6.Text = "Watcher2" Then
           
            If ComboBox1.Enabled = True Then
                DataGridView1.Hide()
                DataGridView2.Show()
                DataGridView3.Hide()
                DataGridView2.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)
                data.DataGridView5.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)

                Dim sum1 As Decimal
                For Each num As DataGridViewRow In DataGridView2.Rows

                    sum1 += num.Cells(4).Value
                Next
                Label10.Text = sum1

            ElseIf ComboBox2.Enabled = True Then
                DataGridView1.Hide()
                DataGridView2.Show()
                DataGridView3.Hide()
                DataGridView2.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)
                data.DataGridView5.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)

                Dim sum1 As Decimal
                For Each num As DataGridViewRow In DataGridView2.Rows

                    sum1 += num.Cells(4).Value
                Next
                Label10.Text = sum1

            End If

        Else
            If ComboBox1.Enabled = True Then
                DataGridView1.Hide()
                DataGridView2.Hide()
                DataGridView3.Show()

                DataGridView3.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)
                data.DataGridView6.Rows.Add(ComboBox1.Text, Form3.Label4.Text, Label7.Text, Label5.Text, Label9.Text)

                Dim sum2 As Decimal
                For Each num As DataGridViewRow In DataGridView3.Rows

                    sum2 += num.Cells(4).Value
                Next
                Label10.Text = sum2

            ElseIf ComboBox2.Enabled = True Then
                DataGridView1.Hide()
                DataGridView2.Hide()
                DataGridView3.Show()
                DataGridView3.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)
                data.DataGridView6.Rows.Add(ComboBox2.Text, Form3.Label4.Text, Label7.Text, Label6.Text, Label9.Text)

                Dim sum2 As Decimal
                For Each num As DataGridViewRow In DataGridView3.Rows

                    sum2 += num.Cells(4).Value
                Next
                Label10.Text = sum2


            End If
        End If

        Label12.Show()
        Label10.Show()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        ComboBox3.Enabled = False
        Button2.Enabled = False


    End Sub

   

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        ComboBox3.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = False
    End Sub
End Class