Public Class MachineProblem2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MachineProblem1.Show()
    End Sub

    Private Sub MachineProblem2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Box 1
        txtRes1.Enabled = False
        ' Box 2
        txtCost2.Enabled = False
        txtTax2.Enabled = False
        txtTotal2.Enabled = False
        ' Box 3
        txtDiscAmt3.Enabled = False
        txtAmt3.Enabled = False

    End Sub

    Private Sub btnComp1_Click(sender As Object, e As EventArgs) Handles btnComp1.Click
        inventoryValue(txtCost1, txtQuant1, txtDesc1, txtRes1)
    End Sub

    Private Sub btnComp2_Click(sender As Object, e As EventArgs) Handles btnComp2.Click
        salesTaxValue(txtPrice2, txtQuant2, txtCost2, txtTax2, txtTotal2)
    End Sub

    Private Sub btnComp3_Click(sender As Object, e As EventArgs) Handles btnComp3.Click
        discountValue(txtPrice3, txtDesc3, txtDiscAmt3, txtAmt3)
    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click, btnClear1.Click, btnClear2.Click
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnClear1"
                clearAll({txtCost1, txtQuant1, txtDesc1, txtRes1})
            Case "btnClear2"
                clearAll({txtPrice2, txtQuant2, txtCost2, txtTax2, txtTotal2})
            Case "btnClear3"
                clearAll({txtPrice3, txtDesc3, txtDiscAmt3, txtAmt3})
        End Select

    End Sub
End Class