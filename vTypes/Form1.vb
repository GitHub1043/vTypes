Public Class Form1

    Private Sub btnInteger_Click(sender As Object, e As EventArgs) Handles btnInteger.Click

        ' A variable is a container for information
        ' Dim= dimension. sets space for the variable
        ' intNumber is the label (name)
        ' Integer is the type of the Variable

        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim intAnswer As Integer

        intNumber1 = 7
        ' NOT an equation, this is an action
        ' intNumber1 "Get the Value" 7
        intNumber2 = 2.4
        ' Integers cannot handle decimals
        ' They will just disappear...
        ' intNumber2 is 2 NOT 2.4
        intAnswer = intNumber1 / intNumber2
        ' / rounds off values

        lblDisplay.Text = "Answer: " & intAnswer
    End Sub

    Private Sub btnSingle_Click(sender As Object, e As EventArgs) Handles btnSingle.Click

        Dim sngNumber1 As Single
        Dim sngNumber2 As Single
        Dim sngAnswer As Single
        ' Variable names cannot conatin spaces!
        ' MUST start with a letter
        ' CAN contain a number (just not at start)
        ' written in camelCase

        sngNumber1 = 7
        sngNumber2 = 2.4
        sngAnswer = sngNumber1 / sngNumber2
        lblDisplay.Text = "Answer: " & sngAnswer
        ' Singles are numbers that can handle decimals

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnChar.Click
        Dim chaLetter1 As Char
        ' a Char can hold a single "character"
        ' a letter, a number(single digit), space
        Dim chaLetter2 As Char
        ' Green squiggle is a warning
        ' This one is for an unused variable

        chaLetter1 = "A"

        lblDisplay.Text = chaLetter1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim sngNum1 As Single = 78
        Dim sngNum2 As Single = 64
        Dim sngNum3 As Single = 89
        Dim sngNum4 As Single = 91
        ' variable assignment upon declaration

        Dim sngAverage As Single
        sngAverage = (sngNum1 + sngNum2 + sngNum3 + sngNum4) / 4
        ' BODMAS
        ' Brackets
        ' Orders(exponents, squareRoots)
        ' Division
        ' Multiplication
        ' Addition
        ' Subtractions

        lblDisplay.Text = sngAverage

    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class
