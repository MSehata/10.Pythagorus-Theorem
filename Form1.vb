Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalculateAdjacent_Click(sender As Object, e As EventArgs) Handles btnCalculateAdjacent.Click
        Dim hypotenuse As Double, opposite As Double
        hypotenuse = Val(txtHypotenuse.Text)
        opposite = Val(txtOpposite.Text)
        txtAdjacent.Text = ((hypotenuse ^ 2 - opposite ^ 2) ^ 0.5).ToString("F2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculateOpposite_Click(sender As Object, e As EventArgs) Handles btnCalculateOpposite.Click
        Dim hypotenuse As Double, adjacent As Double
        hypotenuse = Val(txtHypotenuse.Text)
        adjacent = Val(txtAdjacent.Text)
        txtOpposite.Text = ((hypotenuse ^ 2 - adjacent ^ 2) ^ 0.5).ToString("F2")
    End Sub

    Private Sub btnCalculateHypotenuse_Click(sender As Object, e As EventArgs) Handles btnCalculateHypotenuse.Click
        Dim opposite As Double, adjacent As Double
        opposite = Val(txtOpposite.Text)
        adjacent = Val(txtAdjacent.Text)
        txtHypotenuse.Text = ((opposite ^ 2 + adjacent ^ 2) ^ 0.5).ToString("F2")
    End Sub
End Class
