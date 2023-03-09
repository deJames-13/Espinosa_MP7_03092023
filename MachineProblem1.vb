Public Class MachineProblem1

    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        triangleArea(txtHeight, txtBase, areaOfTriangle)
    End Sub
    Private Sub btnARectangle_Click(sender As Object, e As EventArgs) Handles btnARectangle.Click
        rectangleArea(txtWidth, txtRecHeight, areaOfRectangle)
    End Sub

    Private Sub btnACircle_Click_1(sender As Object, e As EventArgs) Handles btnACircle.Click
        circleArea(circRad, circArea)
    End Sub

    Private Sub btnVCylinder_Click(sender As Object, e As EventArgs) Handles btnVCylinder.Click
        cylinderVolume(cylRad, cylHeight, cylVol)
    End Sub

    Private Sub btnVCone_Click(sender As Object, e As EventArgs) Handles btnVCone.Click
        coneVolume(coneRad, coneHeight, coneVol)
    End Sub

    Private Sub btnConvertA_Click(sender As Object, e As EventArgs) Handles btnConvertA.Click
        poundKiloConversion(poundVal, toKilo, kiloVal, toPound)
    End Sub

    Private Sub btnConverB_Click(sender As Object, e As EventArgs) Handles btnConverB.Click
        temperatureConversion(farenVal, celsiusVal)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        MachineProblem2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        MachineProblem2.Close()
    End Sub
End Class
