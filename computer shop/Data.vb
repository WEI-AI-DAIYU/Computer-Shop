Public Class data

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Watcher1"
        Label1.Show()
        DataGridView1.Show()
        DataGridView4.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView5.Hide()
        DataGridView6.Hide()

        Label2.Show()
        Label3.Show()
        Label10.Show()
        Label15.Show()

        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label11.Hide()
        Label16.Hide()
        Label12.Hide()
        Label17.Hide()
        Label13.Hide()
        Label18.Hide()

        Label14.Show()
        Label19.Show()


        'Watcher1
        'PC
        Dim sum1 As Decimal
        For Each num As DataGridViewRow In DataGridView1.Rows

            sum1 += num.Cells(3).Value
        Next
        Label3.Text = sum1
        'Other services
        Dim sum4 As Decimal
        For Each num As DataGridViewRow In DataGridView4.Rows

            sum4 += num.Cells(4).Value
        Next
        Label10.Text = sum4



        'Watcher2
        'PC
        Dim sum2 As Decimal
        For Each num As DataGridViewRow In DataGridView2.Rows

            sum2 += num.Cells(3).Value
        Next
        Label5.Text = sum2
        'Other Services
        Dim sum5 As Decimal
        For Each num As DataGridViewRow In DataGridView5.Rows

            sum5 += num.Cells(4).Value
        Next
        Label11.Text = sum5


        'Owner
        'PC
        Dim sum3 As Decimal
        For Each num As DataGridViewRow In DataGridView3.Rows

            sum3 += num.Cells(3).Value
        Next
        Label7.Text = sum3
        'Other Services
        Dim sum6 As Decimal
        For Each num As DataGridViewRow In DataGridView6.Rows

            sum6 += num.Cells(4).Value
        Next
        Label12.Text = sum6

        Label15.Text = Val(Label3.Text) + Val(Label10.Text)

    End Sub

    Private Sub data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Hide()
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
        DataGridView5.Hide()
        DataGridView6.Hide()

        Label2.Text = "Watcher1"
        Label4.Text = "Watcher2"
        Label6.Text = "Owner"
        Label8.Text = "TOTAL"
        Label14.Text = "Terminal PC"
        Label19.Text = "Other Services"

        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()

        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()

        Label14.Hide()
        Label19.Hide()






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Watcher2"
        Label1.Show()
        DataGridView2.Show()
        DataGridView5.Show()
        DataGridView1.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
        DataGridView6.Hide()

        Label2.Hide()
        Label3.Hide()
        Label10.Hide()
        Label15.Hide()

        Label4.Show()
        Label5.Show()
        Label11.Show()
        Label16.Show()

        Label6.Hide()
        Label7.Hide()
        Label12.Hide()
        Label17.Hide()

        Label8.Hide()
        Label9.Hide()
        Label13.Hide()
        Label18.Hide()

        Label14.Show()
        Label19.Show()


        'Watcher1
        'PC
        Dim sum1 As Decimal
        For Each num As DataGridViewRow In DataGridView1.Rows

            sum1 += num.Cells(3).Value
        Next
        Label3.Text = sum1
        'Other services
        Dim sum4 As Decimal
        For Each num As DataGridViewRow In DataGridView4.Rows

            sum4 += num.Cells(4).Value
        Next
        Label10.Text = sum4



        'Watcher2
        'PC
        Dim sum2 As Decimal
        For Each num As DataGridViewRow In DataGridView2.Rows

            sum2 += num.Cells(3).Value
        Next
        Label5.Text = sum2
        'Other Services
        Dim sum5 As Decimal
        For Each num As DataGridViewRow In DataGridView5.Rows

            sum5 += num.Cells(4).Value
        Next
        Label11.Text = sum5



        'Owner
        'PC
        Dim sum3 As Decimal
        For Each num As DataGridViewRow In DataGridView3.Rows

            sum3 += num.Cells(3).Value
        Next
        Label7.Text = sum3
        'Other Services
        Dim sum6 As Decimal
        For Each num As DataGridViewRow In DataGridView6.Rows

            sum6 += num.Cells(4).Value
        Next
        Label12.Text = sum6

        
        Label16.Text = Val(Label5.Text) + Val(Label11.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = "Owner"
        Label1.Show()
        DataGridView3.Show()
        DataGridView6.Show()
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView4.Hide()
        DataGridView5.Hide()

        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label15.Show()
        Label16.Show()
        Label17.Show()
        Label18.Show()
        Label14.Show()
        Label19.Show()


        'Watcher1
        'PC
        Dim sum1 As Decimal
        For Each num As DataGridViewRow In DataGridView1.Rows

            sum1 += num.Cells(3).Value
        Next
        Label3.Text = sum1
        'Other services
        Dim sum4 As Decimal
        For Each num As DataGridViewRow In DataGridView4.Rows

            sum4 += num.Cells(4).Value
        Next
        Label10.Text = sum4



        'Watcher2
        'PC
        Dim sum2 As Decimal
        For Each num As DataGridViewRow In DataGridView2.Rows

            sum2 += num.Cells(3).Value
        Next
        Label5.Text = sum2
        'Other Services
        Dim sum5 As Decimal
        For Each num As DataGridViewRow In DataGridView5.Rows

            sum5 += num.Cells(4).Value
        Next
        Label11.Text = sum5



        'Owner
        'PC
        Dim sum3 As Decimal
        For Each num As DataGridViewRow In DataGridView3.Rows

            sum3 += num.Cells(3).Value
        Next
        Label7.Text = sum3
        'Other Services
        Dim sum6 As Decimal
        For Each num As DataGridViewRow In DataGridView6.Rows

            sum6 += num.Cells(4).Value
        Next
        Label12.Text = sum6

        Label15.Text = Val(Label3.Text) + Val(Label10.Text)
        Label16.Text = Val(Label5.Text) + Val(Label11.Text)
        Label17.Text = Val(Label7.Text) + Val(Label12.Text)
        Label9.Text = Val(Label3.Text) + Val(Label5.Text) + Val(Label7.Text)
        Label13.Text = Val(Label10.Text) + Val(Label11.Text) + Val(Label12.Text)
        Label18.Text = Val(Label15.Text) + Val(Label16.Text) + Val(Label17.Text)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
        Label1.Hide()
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
        DataGridView5.Hide()
        DataGridView6.Hide()

        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()

        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()

        Label14.Hide()
        Label19.Hide()

    End Sub


   
End Class