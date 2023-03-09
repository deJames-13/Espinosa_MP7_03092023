

Module ComputationModule
    Const PI As Decimal = 3.14159
    Public Sub triangleArea(ByRef txtHeight As TextBox, ByRef txtBase As TextBox, ByRef areaOfTriangle As TextBox)
        ' For triangle
        Dim iHeight, iBase As Integer
        If Not IsNumeric(txtHeight.Text) OrElse Not IsNumeric(txtBase.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iHeight = txtHeight.Text
        iBase = txtBase.Text
        areaOfTriangle.Text = (1 / 2) * iBase * iHeight
    End Sub
    Public Sub rectangleArea(ByRef txtWidth As TextBox, ByRef txtRecHeight As TextBox, ByRef areaOfRectangle As TextBox)
        ' For rectangle
        Dim iHeight, iWidth As Integer
        If Not IsNumeric(txtWidth.Text) OrElse Not IsNumeric(txtRecHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iHeight = txtRecHeight.Text
        iWidth = txtWidth.Text
        areaOfRectangle.Text = iHeight * iWidth
    End Sub
    Public Sub circleArea(ByRef circRad As TextBox, ByRef circArea As TextBox)
        ' For circle
        Dim iRad As Integer
        If Not IsNumeric(circRad.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = circRad.Text
        circArea.Text = PI * iRad * iRad
    End Sub
    Public Sub cylinderVolume(ByRef cylRad As TextBox, ByRef cylHeight As TextBox, ByRef cylVol As TextBox)
        ' For cylinder
        Dim iRad, iHeight As Integer
        If Not IsNumeric(cylRad.Text) OrElse Not IsNumeric(cylHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = cylRad.Text
        iHeight = cylHeight.Text
        cylVol.Text = PI * iRad * iRad * iHeight
    End Sub
    Public Sub coneVolume(ByRef coneRad As TextBox, ByRef coneHeight As TextBox, ByRef coneVol As TextBox)
        ' For cone
        Dim iRad, iHeight As Integer
        If Not IsNumeric(coneRad.Text) OrElse Not IsNumeric(coneHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = coneRad.Text
        iHeight = coneHeight.Text
        coneVol.Text = PI * iRad * iRad * (iHeight / 3)
    End Sub

    Public Sub poundKiloConversion(ByRef poundVal As TextBox, ByRef toKilo As TextBox, ByRef kiloVal As TextBox, ByRef toPound As TextBox)
        ' For Pound to Kilo
        Dim iPound, iKilo As Integer
        If Not IsNumeric(poundVal.Text) Then
            MsgBox("Please enter a valid integer for Pound", MessageBoxIcon.Error, "Invalid Number")
        Else
            iPound = poundVal.Text
            toKilo.Text = Convert.ToDouble(iPound / 2.205)
        End If

        If Not IsNumeric(kiloVal.Text) Then
            MsgBox("Please enter a valid integer for Kilo", MessageBoxIcon.Error, "Invalid Number")
        Else
            iKilo = kiloVal.Text
            toPound.Text = Convert.ToDouble(iKilo * 2.205)
        End If
    End Sub
    Public Sub temperatureConversion(ByRef farenVal As TextBox, ByRef celsiusVal As TextBox)
        ' For Temperature conversion
        Dim iFaren As Double
        If Not IsNumeric(farenVal.Text) Then
            MsgBox("Please enter a valid integer for Pound", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iFaren = farenVal.Text
        celsiusVal.Text = (iFaren - 32) / 1.8
    End Sub

    ' Machine Problem 2 Computations
    Public Sub inventoryValue(ByRef txtCost1 As TextBox, ByRef txtQuant1 As TextBox, ByRef txtDesc1 As TextBox, ByRef txtRes1 As TextBox)

        Dim iQuant As Integer
        Dim fCost, fTotal As Double
        Dim strDesc As String
        If (Not IsNumeric(txtCost1.Text)) OrElse (Not IsNumeric(txtQuant1.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        strDesc = txtDesc1.Text
        fCost = Convert.ToDouble(txtCost1.Text)
        iQuant = Convert.ToInt64(txtQuant1.Text)
        fTotal = Convert.ToDouble(fCost * iQuant)
        fTotal = (Double).Parse(fTotal, Globalization.NumberStyles.Currency)

        txtRes1.Text = strDesc & vbCrLf & "Total Value: " & fTotal.ToString("C2")
    End Sub
    Public Sub salesTaxValue(ByRef txtPrice2 As TextBox, ByRef txtQuant2 As TextBox, ByRef txtCost2 As TextBox, ByRef txtTax2 As TextBox, ByRef txtTotal2 As TextBox)

        Const TAX_RATE As Double = 0.05
        Dim iCost, iTaxDue, iTotal, iPrice As Double
        Dim iQuant As Integer

        If (Not IsNumeric(txtPrice2.Text)) OrElse (Not IsNumeric(txtQuant2.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        iQuant = Convert.ToInt64(txtQuant2.Text)
        iPrice = Convert.ToDouble(txtPrice2.Text)

        iCost = iPrice * iQuant
        iTaxDue = iCost * TAX_RATE
        iTotal = iCost + iTaxDue

        txtCost2.Text = iCost.ToString("C2")
        txtTax2.Text = iTaxDue.ToString("C2")
        txtTotal2.Text = iTotal.ToString("C2")
    End Sub
    Public Sub discountValue(ByRef txtPrice3 As TextBox, ByRef txtDesc3 As TextBox, ByRef txtDiscAmt3 As TextBox, ByRef txtAmt3 As TextBox)

        Const DISCOUNT As Double = 0.2
        Dim iPrice, iAmt, iDiscAmt As Decimal
        Dim strDesc As String

        If (Not IsNumeric(txtPrice3.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        strDesc = txtDesc3.Text
        iPrice = Convert.ToDouble(txtPrice3.Text)
        iDiscAmt = iPrice * DISCOUNT
        iAmt = iPrice - iDiscAmt

        txtDiscAmt3.Text = iDiscAmt.ToString("C2")
        txtAmt3.Text = iAmt.ToString("C2")
    End Sub

    Public Sub clearAll(ts As TextBox())
        For Each t In ts
            t.Clear()
        Next
    End Sub

End Module
