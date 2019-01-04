Public Class McDonald_Breaky_Menu
    'Mitchell Van Braeckel
    '04/06/2015
    'Menu selection and order pay calculator for McDonald

    'create grand variable
    Dim inFile As System.IO.StreamReader
    Dim NUM1 As Integer
    Dim NUM2 As Integer
    Dim phrase As String
    Dim grandTphrase As String
    Dim grandTotal As Single

    'create variable for each food item cost, tax by itself, and then total together
    Dim cost1 As Single
    Dim cost2 As Single
    Dim cost3 As Single
    Dim cost4 As Single
    Dim cost5 As Single
    Dim cost6 As Single
    Dim cost7 As Single
    Dim cost8 As Single
    Dim cost9 As Single
    Dim cost10 As Single
    Dim cost11 As Single
    Dim cost12 As Single
    Dim cost13 As Single
    Dim cost14 As Single
    Dim cost15 As Single
    Dim cost16 As Single
    Dim cost17 As Single
    Dim cost18 As Single
    Dim cost19 As Single
    Dim cost20 As Single
    Dim cost21 As Single

    Dim tax1 As Single
    Dim tax2 As Single
    Dim tax3 As Single
    Dim tax4 As Single
    Dim tax5 As Single
    Dim tax6 As Single
    Dim tax7 As Single
    Dim tax8 As Single
    Dim tax9 As Single
    Dim tax10 As Single
    Dim tax11 As Single
    Dim tax12 As Single
    Dim tax13 As Single
    Dim tax14 As Single
    Dim tax15 As Single
    Dim tax16 As Single
    Dim tax17 As Single
    Dim tax18 As Single
    Dim tax19 As Single
    Dim tax20 As Single
    Dim tax21 As Single

    Dim total1 As Single
    Dim total2 As Single
    Dim total3 As Single
    Dim total4 As Single
    Dim total5 As Single
    Dim total6 As Single
    Dim total7 As Single
    Dim total8 As Single
    Dim total9 As Single
    Dim total10 As Single
    Dim total11 As Single
    Dim total12 As Single
    Dim total13 As Single
    Dim total14 As Single
    Dim total15 As Single
    Dim total16 As Single
    Dim total17 As Single
    Dim total18 As Single
    Dim total19 As Single
    Dim total20 As Single
    Dim total21 As Single

    'create variables for input for diff pay methods
    Dim cashPay As Single
    Dim cashChange As Single
    Dim creditNum As String
    Dim debitNum As String

    Dim numPenny As Integer
    Dim numNickel As Integer
    Dim numDime As Integer
    Dim numQuarter As Integer
    Dim numLoon As Integer
    Dim numToon As Integer
    Dim bill5 As Integer
    Dim bill10 As Integer
    Dim bill20 As Integer

    Dim counter20 As Single
    Dim counter10 As Single
    Dim counter5 As Single
    Dim counter2 As Single
    Dim counter1 As Single
    Dim counterQ As Single
    Dim counterD As Single
    Dim counterN As Single
    Dim counterP As Single
    Dim changeCounter As Single
    Dim ccount As Integer
    Dim changePhrase As String

    Dim rndnum As Integer
    Dim letter As String
    '.

    Private Sub McDonald_Breaky_Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'loads the form
        'truly generates rnd #s
        Randomize()
        'resets phrases
        phrase = ""
        grandTphrase = vbCrLf & "Your Grand Total is: "
        changePhrase = ""
        ccount = 0
        'calc rnd 1/2 sale
        rndnum = Int((21 * Rnd()) + 1)
        'changes appropriate costs to 1/2 orig amount and makes blue light sale
        If rndnum = 1 Then
            lblCost1.Text = FormatCurrency(lblCost1.Text * 0.5)
            lblCost1.ForeColor = Color.Blue
        ElseIf rndnum = 2 Then
            lblCost2.Text = FormatCurrency(lblCost2.Text * 0.5)
            lblCost2.ForeColor = Color.Blue
        ElseIf rndnum = 3 Then
            lblCost3.Text = FormatCurrency(lblCost3.Text * 0.5)
            lblCost3.ForeColor = Color.Blue
        ElseIf rndnum = 4 Then
            lblCost4.Text = FormatCurrency(lblCost4.Text * 0.5)
            lblCost4.ForeColor = Color.Blue
        ElseIf rndnum = 5 Then
            lblCost5.Text = FormatCurrency(lblCost5.Text * 0.5)
            lblCost5.ForeColor = Color.Blue
        ElseIf rndnum = 6 Then
            lblCost6.Text = FormatCurrency(lblCost6.Text * 0.5)
            lblCost6.ForeColor = Color.Blue
        ElseIf rndnum = 7 Then
            lblCost7.Text = FormatCurrency(lblCost7.Text * 0.5)
            lblCost7.ForeColor = Color.Blue
        ElseIf rndnum = 8 Then
            lblCost8.Text = FormatCurrency(lblCost8.Text * 0.5)
            lblCost8.ForeColor = Color.Blue
        ElseIf rndnum = 9 Then
            lblCost9.Text = FormatCurrency(lblCost9.Text * 0.5)
            lblCost9.ForeColor = Color.Blue
        ElseIf rndnum = 10 Then
            lblCost10.Text = FormatCurrency(lblCost10.Text * 0.5)
            lblCost10.ForeColor = Color.Blue
        ElseIf rndnum = 11 Then
            lblCost11.Text = FormatCurrency(lblCost11.Text * 0.5)
            lblCost11.ForeColor = Color.Blue
        ElseIf rndnum = 12 Then
            lblCost12.Text = FormatCurrency(lblCost12.Text * 0.5)
            lblCost12.ForeColor = Color.Blue
        ElseIf rndnum = 13 Then
            lblCost13.Text = FormatCurrency(lblCost13.Text * 0.5)
            lblCost13.ForeColor = Color.Blue
        ElseIf rndnum = 14 Then
            lblCost14.Text = FormatCurrency(lblCost14.Text * 0.5)
            lblCost14.ForeColor = Color.Blue
        ElseIf rndnum = 15 Then
            lblCost15.Text = FormatCurrency(lblCost15.Text * 0.5)
            lblCost15.ForeColor = Color.Blue
        ElseIf rndnum = 16 Then
            'also pop
            lblCost18.Text = FormatCurrency(lblCost18.Text * 0.5)
            lblCost18.ForeColor = Color.Blue
        ElseIf rndnum = 17 Then
            lblCost17.Text = FormatCurrency(lblCost17.Text * 0.5)
            lblCost17.ForeColor = Color.Blue
        ElseIf rndnum = 18 Then
            lblCost18.Text = FormatCurrency(lblCost18.Text * 0.5)
            lblCost18.ForeColor = Color.Blue
        ElseIf rndnum = 19 Then
            'also pop
            lblCost18.Text = FormatCurrency(lblCost18.Text * 0.5)
            lblCost18.ForeColor = Color.Blue
        ElseIf rndnum = 20 Then
            lblCost20.Text = FormatCurrency(lblCost20.Text * 0.5)
            lblCost20.ForeColor = Color.Blue
        Else
            'also pop
            lblCost18.Text = FormatCurrency(lblCost18.Text * 0.5)
            lblCost18.ForeColor = Color.Blue

            lblCost21.Text = FormatCurrency(lblCost21.Text * 0.5)
            lblCost21.ForeColor = Color.Blue
            'also the yogurt option
            lblWYogurt.Text = "$0.50"
            lblWYogurt.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub cb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb1.CheckedChanged
        'user checks box for egg mcmuffin
        If cb1.Checked = True Then
            'enables use of corresponding nud
            nud1.Enabled = True
            'sets min & val to 1
            nud1.Minimum = 1
            nud1.Value = 1
        End If
        'user unchecks box for egg mcmuffin
        If cb1.Checked = False Then
            'disables use of corresponding nud
            nud1.Enabled = False
            'sets min & val to 0
            nud1.Minimum = 0
            nud1.Value = 0
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb2.CheckedChanged
        'user checks box for sausage n egg mcmuffin
        If cb2.Checked = True Then
            'enables use of corresponding nud
            nud2.Enabled = True
            'sets min & val to 1
            nud2.Minimum = 1
            nud2.Value = 1
        End If
        'user unchecks box for sausage n egg mcmuffin
        If cb2.Checked = False Then
            'disables use of corresponding nud
            nud2.Enabled = False
            'sets min & val to 0
            nud2.Minimum = 0
            nud2.Value = 0
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb3.CheckedChanged
        'user checks box for bacon n egg mcmuffin
        If cb3.Checked = True Then
            'enables use of corresponding nud
            nud3.Enabled = True
            'sets min & val to 1
            nud3.Minimum = 1
            nud3.Value = 1
        End If
        'user unchecks box for bacon n egg mcmuffin
        If cb3.Checked = False Then
            'disables use of corresponding nud
            nud3.Enabled = False
            'sets min & val to 0
            nud3.Minimum = 0
            nud3.Value = 0
        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb4.CheckedChanged
        'user checks box for bacon egg n cheeses mcgriddles
        If cb4.Checked = True Then
            'enables use of corresponding nud
            nud4.Enabled = True
            'sets min & val to 1
            nud4.Minimum = 1
            nud4.Value = 1
        End If
        'user unchecks box for bacon egg n cheese mcgriddles
        If cb4.Checked = False Then
            'disables use of corresponding nud
            nud4.Enabled = False
            'sets min & val to 0
            nud4.Minimum = 0
            nud4.Value = 0
        End If
    End Sub

    Private Sub cb5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb5.CheckedChanged
        'user checks box for sausage mcmuffin
        If cb5.Checked = True Then
            'enables use of corresponding nud
            nud5.Enabled = True
            'sets min & val to 1
            nud5.Minimum = 1
            nud5.Value = 1
        End If
        'user unchecks box for sausage mcmuffin
        If cb5.Checked = False Then
            'disables use of corresponding nud
            nud5.Enabled = False
            'sets min & val to 0
            nud5.Minimum = 0
            nud5.Value = 0
        End If
    End Sub

    Private Sub cb6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb6.CheckedChanged
        'user checks box for bacon n egg bagel
        If cb6.Checked = True Then
            'enables use of corresponding nud
            nud6.Enabled = True
            'sets min & val to 1
            nud6.Minimum = 1
            nud6.Value = 1
        End If
        'user unchecks box for bacon n egg bagel
        If cb6.Checked = False Then
            'disables use of corresponding nud
            nud6.Enabled = False
            'sets min & val to 0
            nud6.Minimum = 0
            nud6.Value = 0
        End If
    End Sub

    Private Sub cb7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb7.CheckedChanged
        'user checks box for blt bagel
        If cb7.Checked = True Then
            'enables use of corresponding nud
            nud7.Enabled = True
            'sets min & val to 1
            nud7.Minimum = 1
            nud7.Value = 1
        End If
        'user unchecks box for blt bagel
        If cb7.Checked = False Then
            'disables use of corresponding nud
            nud7.Enabled = False
            'sets min & val to 0
            nud7.Minimum = 0
            nud7.Value = 0
        End If
    End Sub

    Private Sub cb8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb8.CheckedChanged
        'user checks box for elt bagel
        If cb8.Checked = True Then
            'enables use of corresponding nud
            nud8.Enabled = True
            'sets min & val to 1
            nud8.Minimum = 1
            nud8.Value = 1
        End If
        'user unchecks box for elt bagel
        If cb8.Checked = False Then
            'disables use of corresponding nud
            nud8.Enabled = False
            'sets min & val to 0
            nud8.Minimum = 0
            nud8.Value = 0
        End If
    End Sub

    Private Sub cb9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb9.CheckedChanged
        'user checks box for breaky burrito
        If cb9.Checked = True Then
            'enables use of corresponding nud
            nud9.Enabled = True
            'sets min & val to 1
            nud9.Minimum = 1
            nud9.Value = 1
        End If
        'user unchecks box for breaky burrito
        If cb9.Checked = False Then
            'disables use of corresponding nud
            nud9.Enabled = False
            'sets min & val to 0
            nud9.Minimum = 0
            nud9.Value = 0
        End If
    End Sub

    Private Sub cb10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb10.CheckedChanged
        'user checks box for hotcakes n sausage
        If cb10.Checked = True Then
            'enables use of corresponding nud
            nud10.Enabled = True
            'sets min & val to 1
            nud10.Minimum = 1
            nud10.Value = 1
        End If
        'user unchecks box for hotcakes n sausage
        If cb10.Checked = False Then
            'disables use of corresponding nud
            nud10.Enabled = False
            'sets min & val to 0
            nud10.Minimum = 0
            nud10.Value = 0
        End If
    End Sub

    Private Sub cb11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb11.CheckedChanged
        'user checks box for oatmeal
        If cb11.Checked = True Then
            'enables use of corresponding nud
            nud11.Enabled = True
            'sets min & val to 1
            nud11.Minimum = 1
            nud11.Value = 1
        End If
        'user unchecks box for oatmeal
        If cb11.Checked = False Then
            'disables use of corresponding nud
            nud11.Enabled = False
            'sets min & val to 0
            nud11.Minimum = 0
            nud11.Value = 0
        End If
    End Sub

    Private Sub cb12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb12.CheckedChanged
        'user checks box for parfait
        If cb12.Checked = True Then
            'enables use of corresponding nud
            nud12.Enabled = True
            'sets min & val to 1
            nud12.Minimum = 1
            nud12.Value = 1
        End If
        'user unchecks box for parfait
        If cb12.Checked = False Then
            'disables use of corresponding nud
            nud12.Enabled = False
            'sets min & val to 0
            nud12.Minimum = 0
            nud12.Value = 0
        End If
    End Sub

    Private Sub cb13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb13.CheckedChanged
        'user checks box for hash browns
        If cb13.Checked = True Then
            'enables use of corresponding nud
            nud13.Enabled = True
            'sets min & val to 1
            nud13.Minimum = 1
            nud13.Value = 1
        End If
        'user unchecks box for hash brown
        If cb13.Checked = False Then
            'disables use of corresponding nud
            nud13.Enabled = False
            'sets min & val to 0
            nud13.Minimum = 0
            nud13.Value = 0
        End If
    End Sub

    Private Sub cb14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb14.CheckedChanged
        'user checks box for muffins
        If cb14.Checked = True Then
            'enables use of corresponding nud
            nud14.Enabled = True
            'sets min & val to 1
            nud14.Minimum = 1
            nud14.Value = 1
            'enables the corresponding cbo(s)
            cboMuffin.Enabled = True
            cboMuffin.Text = "Blueberry"
        End If
        'user unchecks box for muffins
        If cb14.Checked = False Then
            'disables use of corresponding nud
            nud14.Enabled = False
            'sets min & val to 0
            nud14.Minimum = 0
            nud14.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboMuffin.Enabled = False
            cboMuffin.Text = " -- Flavour --"
        End If
    End Sub

    Private Sub cb15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb15.CheckedChanged
        'user checks box for big breaky
        If cb15.Checked = True Then
            'enables use of corresponding nud
            nud15.Enabled = True
            'sets min & val to 1
            nud15.Minimum = 1
            nud15.Value = 1
        End If
        'user unchecks box for big breaky
        If cb15.Checked = False Then
            'disables use of corresponding nud
            nud15.Enabled = False
            'sets min & val to 0
            nud15.Minimum = 0
            nud15.Value = 0
        End If
    End Sub

    Private Sub cb16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb16.CheckedChanged
        'user checks box for juices
        If cb16.Checked = True Then
            'enables use of corresponding nud
            nud16.Enabled = True
            'sets min & val to 1
            nud16.Minimum = 1
            nud16.Value = 1
            'enables the corresponding cbo(s)
            cboJuice.Enabled = True
            cboJuiceS.Enabled = True
            cboJuice.Text = "Orange"
            cboJuiceS.Text = "Small"
        End If
        'user unchecks box for juices
        If cb16.Checked = False Then
            'disables use of corresponding nud
            nud16.Enabled = False
            'sets min & val to 0
            nud16.Minimum = 0
            nud16.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboJuice.Enabled = False
            cboJuiceS.Enabled = False
            cboJuice.Text = " -- Flavour --"
            cboJuiceS.Text = " -- Size --"
        End If
    End Sub

    Private Sub cb17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb17.CheckedChanged
        'user checks box for milks
        If cb17.Checked = True Then
            'enables use of corresponding nud
            nud17.Enabled = True
            'sets min & val to 1
            nud17.Minimum = 1
            nud17.Value = 1
            'enables the corresponding cbo(s)
            cboMilk.Enabled = True
            cboMilk.Text = "White Milk 2% P. Skim"
        End If
        'user unchecks box for milks
        If cb17.Checked = False Then
            'disables use of corresponding nud
            nud17.Enabled = False
            'sets min & val to 0
            nud17.Minimum = 0
            nud17.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboMilk.Enabled = False
            cboMilk.Text = " -- Flavour --"
        End If
    End Sub

    Private Sub cb18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb18.CheckedChanged
        'user checks box for pops
        If cb18.Checked = True Then
            'enables use of corresponding nud
            nud18.Enabled = True
            'sets min & val to 1
            nud18.Minimum = 1
            nud18.Value = 1
            'enables the corresponding cbo(s)
            cboPop.Enabled = True
            cboPopS.Enabled = True
            cboPop.Text = "Barq's® Root Beer"
            cboPopS.Text = "Regular"
        End If
        'user unchecks box for pops
        If cb18.Checked = False Then
            'disables use of corresponding nud
            nud18.Enabled = False
            'sets min & val to 0
            nud18.Minimum = 0
            nud18.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboPop.Enabled = False
            cboPopS.Enabled = False
            cboPop.Text = " -- Flavour --"
            cboPopS.Text = " -- Size --"
        End If
    End Sub

    Private Sub cb19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb19.CheckedChanged
        'user checks box for teas
        If cb19.Checked = True Then
            'enables use of corresponding nud
            nud19.Enabled = True
            'sets min & val to 1
            nud19.Minimum = 1
            nud19.Value = 1
            'enables the corresponding cbo(s)
            cboPTea.Enabled = True
            cboPTeaS.Enabled = True
            cboPTea.Text = "Green Tea"
            cboPTeaS.Text = "Regular"
        End If
        'user unchecks box for teas
        If cb19.Checked = False Then
            'disables use of corresponding nud
            nud19.Enabled = False
            'sets min & val to 0
            nud19.Minimum = 0
            nud19.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboPTea.Enabled = False
            cboPTeaS.Enabled = False
            cboPTea.Text = " -- Flavour --"
            cboPTeaS.Text = " -- Size --"
        End If
    End Sub

    Private Sub cb20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb20.CheckedChanged
        'user checks box for water
        If cb20.Checked = True Then
            'enables use of corresponding nud
            nud20.Enabled = True
            'sets min & val to 1
            nud20.Minimum = 1
            nud20.Value = 1
        End If
        'user unchecks box for water
        If cb20.Checked = False Then
            'disables use of corresponding nud
            nud20.Enabled = False
            'sets min & val to 0
            nud20.Minimum = 0
            nud20.Value = 0
        End If
    End Sub

    Private Sub cb21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb21.CheckedChanged
        'user checks box for smoothies
        If cb21.Checked = True Then
            'enables use of corresponding nud
            nud21.Enabled = True
            'sets min & val to 1
            nud21.Minimum = 1
            nud21.Value = 1
            'enables the corresponding cbo(s)
            cboSmoothie.Enabled = True
            cboSmoothieS.Enabled = True
            cboSmoothie.Text = "Strawberry Banana"
            cboSmoothieS.Text = "Regular"
            'enables the yogurt option
            cbWYogurt.Enabled = True
            lblWYogurt.Enabled = True
            cbWYogurt.Checked = False
        End If
        'user unchecks box for smoothies
        If cb21.Checked = False Then
            'disables use of corresponding nud
            nud21.Enabled = False
            'sets min & val to 0
            nud21.Minimum = 0
            nud21.Value = 0
            'disables the corresponding cbo(s) & sets back to standard text
            cboSmoothie.Enabled = False
            cboSmoothieS.Enabled = False
            cboSmoothie.Text = " -- Flavour --"
            cboSmoothieS.Text = " -- Size --"
            'disables the yogurt option
            cbWYogurt.Enabled = False
            lblWYogurt.Enabled = False
            cbWYogurt.Checked = False
        End If
    End Sub

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        'calc the cost w/ & w/o tax and displays it to the user

        'checks which cb are checked

        If cb1.Checked = True Then
            'calc costs
            cost1 = lblCost1.Text * nud1.Value
            tax1 = cost1 * 0.13
            total1 = cost1 + tax1
            phrase = phrase & cb1.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost1.Text) & vbCrLf & vbTab & "Quantity: " & nud1.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost1) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax1) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total1) & vbCrLf & vbCrLf
        Else
            cost1 = 0
            tax1 = 0
            total1 = 0
        End If

        If cb2.Checked = True Then
            'calc costs
            cost2 = lblCost2.Text * nud2.Value
            tax2 = cost2 * 0.13
            total2 = cost2 + tax2
            phrase = phrase & cb2.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost2.Text) & vbCrLf & vbTab & "Quantity: " & nud2.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost2) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax2) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total2) & vbCrLf & vbCrLf
        Else
            cost2 = 0
            tax2 = 0
            total2 = 0
        End If

        If cb3.Checked = True Then
            'calc costs
            cost3 = lblCost3.Text * nud3.Value
            tax3 = cost3 * 0.13
            total3 = cost3 + tax3
            phrase = phrase & cb3.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost3.Text) & vbCrLf & vbTab & "Quantity: " & nud3.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost3) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax3) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total3) & vbCrLf & vbCrLf
        Else
            cost3 = 0
            tax3 = 0
            total3 = 0
        End If

        If cb4.Checked = True Then
            'calc costs
            cost4 = lblCost4.Text * nud4.Value
            tax4 = cost4 * 0.13
            total4 = cost4 + tax4
            phrase = phrase & cb4.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost4.Text) & vbCrLf & vbTab & "Quantity: " & nud4.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost4) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax4) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total4) & vbCrLf & vbCrLf
        Else
            cost4 = 0
            tax4 = 0
            total4 = 0
        End If

        If cb5.Checked = True Then
            'calc costs
            cost5 = lblCost5.Text * nud5.Value
            tax5 = cost5 * 0.13
            total5 = cost5 + tax5
            phrase = phrase & cb5.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost5.Text) & vbCrLf & vbTab & "Quantity: " & nud5.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost5) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax5) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total5) & vbCrLf & vbCrLf
        Else
            cost5 = 0
            tax5 = 0
            total5 = 0
        End If

        If cb6.Checked = True Then
            'calc costs
            cost6 = lblCost6.Text * nud6.Value
            tax6 = cost6 * 0.13
            total6 = cost6 + tax6
            phrase = phrase & cb6.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost6.Text) & vbCrLf & vbTab & "Quantity: " & nud6.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost6) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax6) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total6) & vbCrLf & vbCrLf
        Else
            cost6 = 0
            tax6 = 0
            total6 = 0
        End If

        If cb7.Checked = True Then
            'calc costs
            cost7 = lblCost7.Text * nud7.Value
            tax7 = cost7 * 0.13
            total7 = cost7 + tax7
            phrase = phrase & cb7.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost7.Text) & vbCrLf & vbTab & "Quantity: " & nud7.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost7) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax7) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total7) & vbCrLf & vbCrLf
        Else
            cost7 = 0
            tax7 = 0
            total7 = 0
        End If

        If cb8.Checked = True Then
            'calc costs
            cost8 = lblCost8.Text * nud8.Value
            tax8 = cost8 * 0.13
            total8 = cost8 + tax8
            phrase = phrase & cb8.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost8.Text) & vbCrLf & vbTab & "Quantity: " & nud8.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost8) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax8) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total8) & vbCrLf & vbCrLf
        Else
            cost8 = 0
            tax8 = 0
            total8 = 0
        End If

        If cb9.Checked = True Then
            'calc costs
            cost9 = lblCost9.Text * nud9.Value
            tax9 = cost9 * 0.13
            total9 = cost9 + tax9
            phrase = phrase & cb9.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost9.Text) & vbCrLf & vbTab & "Quantity: " & nud9.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost9) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax9) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total9) & vbCrLf & vbCrLf
        Else
            cost9 = 0
            tax9 = 0
            total9 = 0
        End If

        If cb10.Checked = True Then
            'calc costs
            cost10 = lblCost10.Text * nud10.Value
            tax10 = cost10 * 0.13
            total10 = cost10 + tax10
            phrase = phrase & cb10.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost10.Text) & vbCrLf & vbTab & "Quantity: " & nud10.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost10) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax10) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total10) & vbCrLf & vbCrLf
        Else
            cost10 = 0
            tax10 = 0
            total10 = 0
        End If

        If cb11.Checked = True Then
            'calc costs
            cost11 = lblCost11.Text * nud11.Value
            tax11 = cost11 * 0.13
            total11 = cost11 + tax11
            phrase = phrase & cb11.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost11.Text) & vbCrLf & vbTab & "Quantity: " & nud11.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost11) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax11) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total11) & vbCrLf & vbCrLf
        Else
            cost11 = 0
            tax11 = 0
            total11 = 0
        End If

        If cb12.Checked = True Then
            'calc costs
            cost12 = lblCost12.Text * nud12.Value
            tax12 = cost12 * 0.13
            total12 = cost12 + tax12
            phrase = phrase & cb12.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost12.Text) & vbCrLf & vbTab & "Quantity: " & nud12.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost12) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax12) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total12) & vbCrLf & vbCrLf
        Else
            cost12 = 0
            tax12 = 0
            total12 = 0
        End If

        If cb13.Checked = True Then
            'calc costs
            cost13 = lblCost13.Text * nud13.Value
            tax13 = cost13 * 0.13
            total13 = cost13 + tax13
            phrase = phrase & cb13.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost13.Text) & vbCrLf & vbTab & "Quantity: " & nud13.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost13) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax13) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total13) & vbCrLf & vbCrLf
        Else
            cost13 = 0
            tax13 = 0
            total13 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb14.Checked = True Then
            'calc costs
            cost14 = lblCost14.Text * nud14.Value
            tax14 = cost14 * 0.13
            total14 = cost14 + tax14
            phrase = phrase & cboMuffin.Text & " " & cb14.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost14.Text) & vbCrLf & vbTab & "Quantity: " & nud14.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost14) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax14) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total14) & vbCrLf & vbCrLf
        Else
            cost14 = 0
            tax14 = 0
            total14 = 0
        End If

        If cb15.Checked = True Then
            'calc costs
            cost15 = lblCost15.Text * nud15.Value
            tax15 = cost15 * 0.13
            total15 = cost15 + tax15
            phrase = phrase & cb15.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost15.Text) & vbCrLf & vbTab & "Quantity: " & nud15.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost15) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax15) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total15) & vbCrLf & vbCrLf
        Else
            cost15 = 0
            tax15 = 0
            total15 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb16.Checked = True Then
            'calc costs
            cost16 = lblCost16.Text * nud16.Value
            tax16 = cost16 * 0.13
            total16 = cost16 + tax16
            phrase = phrase & cboJuiceS.Text & " " & cboJuice.Text & " " & cb16.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost16.Text) & vbCrLf & vbTab & "Quantity: " & nud16.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost16) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax16) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total16) & vbCrLf & vbCrLf
        Else
            cost16 = 0
            tax16 = 0
            total16 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb17.Checked = True Then
            'calc costs
            cost17 = lblCost17.Text * nud17.Value
            tax17 = cost17 * 0.13
            total17 = cost17 + tax17
            phrase = phrase & cboMilk.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost17.Text) & vbCrLf & vbTab & "Quantity: " & nud17.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost17) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax17) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total17) & vbCrLf & vbCrLf
        Else
            cost17 = 0
            tax17 = 0
            total17 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb18.Checked = True Then
            'calc costs
            cost18 = lblCost18.Text * nud18.Value
            tax18 = cost18 * 0.13
            total18 = cost18 + tax18
            phrase = phrase & cboPopS.Text & " " & cboPop.Text & " " & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost18.Text) & vbCrLf & vbTab & "Quantity: " & nud18.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost18) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax18) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total18) & vbCrLf & vbCrLf
        Else
            cost18 = 0
            tax18 = 0
            total18 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb19.Checked = True Then
            'calc costs
            cost19 = lblCost19.Text * nud19.Value
            tax19 = cost19 * 0.13
            total19 = cost19 + tax19
            phrase = phrase & cboPTeaS.Text & " " & cb19.Text & ": " & cboPTea.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost19.Text) & vbCrLf & vbTab & "Quantity: " & nud19.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost19) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax19) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total19) & vbCrLf & vbCrLf
        Else
            cost19 = 0
            tax19 = 0
            total19 = 0
        End If

        If cb20.Checked = True Then
            'calc costs
            cost20 = lblCost20.Text * nud20.Value
            tax20 = cost20 * 0.13
            total20 = cost20 + tax20
            phrase = phrase & cb20.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost20.Text) & vbCrLf & vbTab & "Quantity: " & nud20.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost20) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax20) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total20) & vbCrLf & vbCrLf
        Else
            cost20 = 0
            tax20 = 0
            total20 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb21.Checked = True Then
            'calc costs
            If cbWYogurt.Checked = True Then
                'add yogurt cost (+$1)
                cost21 = (lblCost21.Text + 1) * nud21.Value
                tax21 = cost21 * 0.13
                total21 = cost21 + tax21
                phrase = phrase & cboSmoothieS.Text & " " & cboSmoothie.Text & " " & cb21.Text & " w/ Yogurt" & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost21.Text) &
                        " ( + " & lblWYogurt.Text & ")" & vbCrLf & vbTab & "Quantity: " & nud21.Value & vbCrLf &
                        vbTab & "Subtotal: " & FormatCurrency(cost21) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax21) & vbCrLf &
                        vbTab & "Final Amount: " & FormatCurrency(total21) & vbCrLf & vbCrLf
            Else
                'normal cost
                cost21 = lblCost21.Text * nud21.Value
                tax21 = cost21 * 0.13
                total21 = cost21 + tax21
                phrase = phrase & cboSmoothieS.Text & " " & cboSmoothie.Text & " " & cb21.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost21.Text) & vbCrLf & vbTab & "Quantity: " & nud21.Value & vbCrLf &
                        vbTab & "Subtotal: " & FormatCurrency(cost21) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax21) & vbCrLf &
                        vbTab & "Final Amount: " & FormatCurrency(total21) & vbCrLf & vbCrLf
            End If
        Else
            'don't calc
            'error -> no flavour & no size
            cost21 = 0
            tax21 = 0
            total21 = 0
        End If

        'calc the users grand total w/tax and display at btm of text receipt
        grandTotal = total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9 + total10 + total11 + total12 + total13 + total14 + total15 + total16 + total17 + total18 + total19 + total20 + total21

        'display text in the receipt to the user regarding costs
        txtCart.Text = phrase & grandTphrase & FormatCurrency(grandTotal)

        'reset phrase
        phrase = ""

        'enables confirm btn
        btnConfirm.Enabled = True
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        'confirms the selected items would like to be purchased and continues to checkout

        'same as calc btn
        'calc the cost w/ & w/o tax and displays it to the user

        'checks which cb are checked

        If cb1.Checked = True Then
            'calc costs
            cost1 = lblCost1.Text * nud1.Value
            tax1 = cost1 * 0.13
            total1 = cost1 + tax1
            phrase = phrase & cb1.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost1.Text) & vbCrLf & vbTab & "Quantity: " & nud1.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost1) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax1) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total1) & vbCrLf & vbCrLf
        Else
            cost1 = 0
            tax1 = 0
            total1 = 0
        End If

        If cb2.Checked = True Then
            'calc costs
            cost2 = lblCost2.Text * nud2.Value
            tax2 = cost2 * 0.13
            total2 = cost2 + tax2
            phrase = phrase & cb2.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost2.Text) & vbCrLf & vbTab & "Quantity: " & nud2.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost2) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax2) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total2) & vbCrLf & vbCrLf
        Else
            cost2 = 0
            tax2 = 0
            total2 = 0
        End If

        If cb3.Checked = True Then
            'calc costs
            cost3 = lblCost3.Text * nud3.Value
            tax3 = cost3 * 0.13
            total3 = cost3 + tax3
            phrase = phrase & cb3.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost3.Text) & vbCrLf & vbTab & "Quantity: " & nud3.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost3) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax3) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total3) & vbCrLf & vbCrLf
        Else
            cost3 = 0
            tax3 = 0
            total3 = 0
        End If

        If cb4.Checked = True Then
            'calc costs
            cost4 = lblCost4.Text * nud4.Value
            tax4 = cost4 * 0.13
            total4 = cost4 + tax4
            phrase = phrase & cb4.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost4.Text) & vbCrLf & vbTab & "Quantity: " & nud4.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost4) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax4) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total4) & vbCrLf & vbCrLf
        Else
            cost4 = 0
            tax4 = 0
            total4 = 0
        End If

        If cb5.Checked = True Then
            'calc costs
            cost5 = lblCost5.Text * nud5.Value
            tax5 = cost5 * 0.13
            total5 = cost5 + tax5
            phrase = phrase & cb5.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost5.Text) & vbCrLf & vbTab & "Quantity: " & nud5.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost5) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax5) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total5) & vbCrLf & vbCrLf
        Else
            cost5 = 0
            tax5 = 0
            total5 = 0
        End If

        If cb6.Checked = True Then
            'calc costs
            cost6 = lblCost6.Text * nud6.Value
            tax6 = cost6 * 0.13
            total6 = cost6 + tax6
            phrase = phrase & cb6.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost6.Text) & vbCrLf & vbTab & "Quantity: " & nud6.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost6) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax6) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total6) & vbCrLf & vbCrLf
        Else
            cost6 = 0
            tax6 = 0
            total6 = 0
        End If

        If cb7.Checked = True Then
            'calc costs
            cost7 = lblCost7.Text * nud7.Value
            tax7 = cost7 * 0.13
            total7 = cost7 + tax7
            phrase = phrase & cb7.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost7.Text) & vbCrLf & vbTab & "Quantity: " & nud7.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost7) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax7) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total7) & vbCrLf & vbCrLf
        Else
            cost7 = 0
            tax7 = 0
            total7 = 0
        End If

        If cb8.Checked = True Then
            'calc costs
            cost8 = lblCost8.Text * nud8.Value
            tax8 = cost8 * 0.13
            total8 = cost8 + tax8
            phrase = phrase & cb8.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost8.Text) & vbCrLf & vbTab & "Quantity: " & nud8.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost8) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax8) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total8) & vbCrLf & vbCrLf
        Else
            cost8 = 0
            tax8 = 0
            total8 = 0
        End If

        If cb9.Checked = True Then
            'calc costs
            cost9 = lblCost9.Text * nud9.Value
            tax9 = cost9 * 0.13
            total9 = cost9 + tax9
            phrase = phrase & cb9.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost9.Text) & vbCrLf & vbTab & "Quantity: " & nud9.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost9) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax9) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total9) & vbCrLf & vbCrLf
        Else
            cost9 = 0
            tax9 = 0
            total9 = 0
        End If

        If cb10.Checked = True Then
            'calc costs
            cost10 = lblCost10.Text * nud10.Value
            tax10 = cost10 * 0.13
            total10 = cost10 + tax10
            phrase = phrase & cb10.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost10.Text) & vbCrLf & vbTab & "Quantity: " & nud10.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost10) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax10) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total10) & vbCrLf & vbCrLf
        Else
            cost10 = 0
            tax10 = 0
            total10 = 0
        End If

        If cb11.Checked = True Then
            'calc costs
            cost11 = lblCost11.Text * nud11.Value
            tax11 = cost11 * 0.13
            total11 = cost11 + tax11
            phrase = phrase & cb11.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost11.Text) & vbCrLf & vbTab & "Quantity: " & nud11.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost11) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax11) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total11) & vbCrLf & vbCrLf
        Else
            cost11 = 0
            tax11 = 0
            total11 = 0
        End If

        If cb12.Checked = True Then
            'calc costs
            cost12 = lblCost12.Text * nud12.Value
            tax12 = cost12 * 0.13
            total12 = cost12 + tax12
            phrase = phrase & cb12.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost12.Text) & vbCrLf & vbTab & "Quantity: " & nud12.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost12) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax12) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total12) & vbCrLf & vbCrLf
        Else
            cost12 = 0
            tax12 = 0
            total12 = 0
        End If

        If cb13.Checked = True Then
            'calc costs
            cost13 = lblCost13.Text * nud13.Value
            tax13 = cost13 * 0.13
            total13 = cost13 + tax13
            phrase = phrase & cb13.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost13.Text) & vbCrLf & vbTab & "Quantity: " & nud13.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost13) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax13) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total13) & vbCrLf & vbCrLf
        Else
            cost13 = 0
            tax13 = 0
            total13 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb14.Checked = True Then
            'calc costs
            cost14 = lblCost14.Text * nud14.Value
            tax14 = cost14 * 0.13
            total14 = cost14 + tax14
            phrase = phrase & cboMuffin.Text & " " & cb14.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost14.Text) & vbCrLf & vbTab & "Quantity: " & nud14.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost14) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax14) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total14) & vbCrLf & vbCrLf
        Else
            cost14 = 0
            tax14 = 0
            total14 = 0
        End If

        If cb15.Checked = True Then
            'calc costs
            cost15 = lblCost15.Text * nud15.Value
            tax15 = cost15 * 0.13
            total15 = cost15 + tax15
            phrase = phrase & cb15.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost15.Text) & vbCrLf & vbTab & "Quantity: " & nud15.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost15) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax15) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total15) & vbCrLf & vbCrLf
        Else
            cost15 = 0
            tax15 = 0
            total15 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb16.Checked = True Then
            'calc costs
            cost16 = lblCost16.Text * nud16.Value
            tax16 = cost16 * 0.13
            total16 = cost16 + tax16
            phrase = phrase & cboJuiceS.Text & " " & cboJuice.Text & " " & cb16.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost16.Text) & vbCrLf & vbTab & "Quantity: " & nud16.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost16) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax16) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total16) & vbCrLf & vbCrLf
        Else
            cost16 = 0
            tax16 = 0
            total16 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb17.Checked = True Then
            'calc costs
            cost17 = lblCost17.Text * nud17.Value
            tax17 = cost17 * 0.13
            total17 = cost17 + tax17
            phrase = phrase & cboMilk.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost17.Text) & vbCrLf & vbTab & "Quantity: " & nud17.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost17) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax17) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total17) & vbCrLf & vbCrLf
        Else
            cost17 = 0
            tax17 = 0
            total17 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb18.Checked = True Then
            'calc costs
            cost18 = lblCost18.Text * nud18.Value
            tax18 = cost18 * 0.13
            total18 = cost18 + tax18
            phrase = phrase & cboPopS.Text & " " & cboPop.Text & " " & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost18.Text) & vbCrLf & vbTab & "Quantity: " & nud18.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost18) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax18) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total18) & vbCrLf & vbCrLf
        Else
            cost18 = 0
            tax18 = 0
            total18 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb19.Checked = True Then
            'calc costs
            cost19 = lblCost19.Text * nud19.Value
            tax19 = cost19 * 0.13
            total19 = cost19 + tax19
            phrase = phrase & cboPTeaS.Text & " " & cb19.Text & ": " & cboPTea.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost19.Text) & vbCrLf & vbTab & "Quantity: " & nud19.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost19) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax19) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total19) & vbCrLf & vbCrLf
        Else
            cost19 = 0
            tax19 = 0
            total19 = 0
        End If

        If cb20.Checked = True Then
            'calc costs
            cost20 = lblCost20.Text * nud20.Value
            tax20 = cost20 * 0.13
            total20 = cost20 + tax20
            phrase = phrase & cb20.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost20.Text) & vbCrLf & vbTab & "Quantity: " & nud20.Value & vbCrLf &
                    vbTab & "Subtotal: " & FormatCurrency(cost20) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax20) & vbCrLf &
                    vbTab & "Final Amount: " & FormatCurrency(total20) & vbCrLf & vbCrLf
        Else
            cost20 = 0
            tax20 = 0
            total20 = 0
        End If

        'checks to make sure that the proper cbo boxes have been used
        If cb21.Checked = True Then
            'calc costs
            If cbWYogurt.Checked = True Then
                'add yogurt cost (+$1)
                cost21 = (lblCost21.Text + 1) * nud21.Value
                tax21 = cost21 * 0.13
                total21 = cost21 + tax21
                phrase = phrase & cboSmoothieS.Text & " " & cboSmoothie.Text & " " & cb21.Text & " w/ Yogurt" & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost21.Text) &
                        " ( + " & lblWYogurt.Text & ")" & vbCrLf & vbTab & "Quantity: " & nud21.Value & vbCrLf &
                        vbTab & "Subtotal: " & FormatCurrency(cost21) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax21) & vbCrLf &
                        vbTab & "Final Amount: " & FormatCurrency(total21) & vbCrLf & vbCrLf
            Else
                'normal cost
                cost21 = lblCost21.Text * nud21.Value
                tax21 = cost21 * 0.13
                total21 = cost21 + tax21
                phrase = phrase & cboSmoothieS.Text & " " & cboSmoothie.Text & " " & cb21.Text & vbCrLf & vbTab & "Cost: " & FormatCurrency(lblCost21.Text) & vbCrLf & vbTab & "Quantity: " & nud21.Value & vbCrLf &
                        vbTab & "Subtotal: " & FormatCurrency(cost21) & vbCrLf & vbTab & "Tax: " & FormatCurrency(tax21) & vbCrLf &
                        vbTab & "Final Amount: " & FormatCurrency(total21) & vbCrLf & vbCrLf
            End If
        Else
            'don't calc
            'error -> no flavour & no size
            cost21 = 0
            tax21 = 0
            total21 = 0
        End If

        'calc the users grand total w/tax and display at btm of text receipt
        grandTotal = total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9 + total10 + total11 + total12 + total13 + total14 + total15 + total16 + total17 + total18 + total19 + total20 + total21

        'display text in the receipt to the user regarding costs
        txtCart.Text = phrase & grandTphrase & FormatCurrency(grandTotal)

        'reset phrase
        phrase = ""

        'enables confirm btn
        btnConfirm.Enabled = True

        'resets phrase
        phrase = ""

        'disables this btn & calc/update btn
        btnConfirm.Enabled = False
        btnCalc.Enabled = False
        'enables payment method choice btns
        btnCredit.Enabled = True
        btnCash.Enabled = True
        btnDebit.Enabled = True
    End Sub

    Private Sub btnCredit_Click(sender As System.Object, e As System.EventArgs) Handles btnCredit.Click
        'user pays with a credit card
        'disables all pay meth btns
        btnCredit.Enabled = True
        btnCash.Enabled = False
        btnDebit.Enabled = False

        'enables calculator btns
        'creditNum = InputBox("Enter your PIN:", "McDonald's Breakfast Menu - Checkout - Pay with Credit", "0000", 300, 300)
        lblCalculator.Enabled = True
        lblShow.Enabled = True
        btnC0.Enabled = True
        btnC1.Enabled = True
        btnC2.Enabled = True
        btnC3.Enabled = True
        btnC4.Enabled = True
        btnC5.Enabled = True
        btnC6.Enabled = True
        btnC7.Enabled = True
        btnC8.Enabled = True
        btnC9.Enabled = True
        btnCDecimal.Enabled = True
        btnCBack.Enabled = True
        btnCClear.Enabled = True
        btnCEqual.Enabled = True

        'displays msg prompt about pay
        MessageBox.Show("Please enter your PIN:", "McDonald's Breakfast Menu - Checkout - Pay with Credit")

        'places standard code
        lblShow.Text = "0000"
    End Sub

    Private Sub btnCash_Click(sender As System.Object, e As System.EventArgs) Handles btnCash.Click
        'user pays with cash
        'disables all pay meth btns
        btnCredit.Enabled = False
        btnCash.Enabled = True
        btnDebit.Enabled = False

        'enables calculator btns
        'cashPay = InputBox("Enter the amount of cash you are paying ($)(0.00):", "McDonald's Breakfast Menu - Checkout - Pay with Cash", 0, 300, 300)
        lblCalculator.Enabled = True
        lblShow.Enabled = True
        btnC0.Enabled = True
        btnC1.Enabled = True
        btnC2.Enabled = True
        btnC3.Enabled = True
        btnC4.Enabled = True
        btnC5.Enabled = True
        btnC6.Enabled = True
        btnC7.Enabled = True
        btnC8.Enabled = True
        btnC9.Enabled = True
        btnCDecimal.Enabled = True
        btnCBack.Enabled = True
        btnCClear.Enabled = True
        btnCEqual.Enabled = True

        'displays msg prompt about pay
        MessageBox.Show("Enter the amount of cash you are paying ($)(0.00):", "McDonald's Breakfast Menu - Checkout - Pay with Cash")

        'places standard amount
        lblShow.Text = "0"
    End Sub

    Private Sub btnDebit_Click(sender As System.Object, e As System.EventArgs) Handles btnDebit.Click
        'user pays with debit
        'disables all pay meth btns
        btnCredit.Enabled = False
        btnCash.Enabled = False
        btnDebit.Enabled = True

        'enables calculator btns
        'debitNum = InputBox("Enter your PIN:", "McDonald's Breakfast Menu - Checkout - Pay with Debit", "0000", 300, 300)
        lblCalculator.Enabled = True
        lblShow.Enabled = True
        btnC0.Enabled = True
        btnC1.Enabled = True
        btnC2.Enabled = True
        btnC3.Enabled = True
        btnC4.Enabled = True
        btnC5.Enabled = True
        btnC6.Enabled = True
        btnC7.Enabled = True
        btnC8.Enabled = True
        btnC9.Enabled = True
        btnCDecimal.Enabled = True
        btnCBack.Enabled = True
        btnCClear.Enabled = True
        btnCEqual.Enabled = True

        'displays msg prompt about pay
        MessageBox.Show("Enter your PIN:", "McDonald's Breakfast Menu - Checkout - Pay with Debit")

        'places standard code
        lblShow.Text = "0000"
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'cancel all menu selections and return to main menu home screen
        'resets everything
        phrase = ""
        grandTphrase = ""
        grandTotal = 0

        cost1 = 0
        cost2 = 0
        cost3 = 0
        cost4 = 0
        cost5 = 0
        cost6 = 0
        cost7 = 0
        cost8 = 0
        cost9 = 0
        cost10 = 0
        cost11 = 0
        cost12 = 0
        cost13 = 0
        cost14 = 0
        cost15 = 0
        cost16 = 0
        cost17 = 0
        cost18 = 0
        cost19 = 0
        cost20 = 0
        cost21 = 0

        tax1 = 0
        tax2 = 0
        tax3 = 0
        tax4 = 0
        tax5 = 0
        tax6 = 0
        tax7 = 0
        tax8 = 0
        tax9 = 0
        tax10 = 0
        tax11 = 0
        tax12 = 0
        tax13 = 0
        tax14 = 0
        tax15 = 0
        tax16 = 0
        tax17 = 0
        tax18 = 0
        tax19 = 0
        tax20 = 0
        tax21 = 0

        total1 = 0
        total2 = 0
        total3 = 0
        total4 = 0
        total5 = 0
        total6 = 0
        total7 = 0
        total8 = 0
        total9 = 0
        total10 = 0
        total11 = 0
        total12 = 0
        total13 = 0
        total14 = 0
        total15 = 0
        total16 = 0
        total17 = 0
        total18 = 0
        total19 = 0
        total20 = 0
        total21 = 0

        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
        cb6.Checked = False
        cb7.Checked = False
        cb8.Checked = False
        cb9.Checked = False
        cb10.Checked = False
        cb11.Checked = False
        cb13.Checked = False
        cb14.Checked = False
        cb15.Checked = False
        cb16.Checked = False
        cb17.Checked = False
        cb18.Checked = False
        cb19.Checked = False
        cb20.Checked = False
        cb21.Checked = False

        nud1.Enabled = False
        nud2.Enabled = False
        nud3.Enabled = False
        nud4.Enabled = False
        nud5.Enabled = False
        nud6.Enabled = False
        nud7.Enabled = False
        nud8.Enabled = False
        nud9.Enabled = False
        nud10.Enabled = False
        nud11.Enabled = False
        nud12.Enabled = False
        nud13.Enabled = False
        nud14.Enabled = False
        nud15.Enabled = False
        nud16.Enabled = False
        nud17.Enabled = False
        nud18.Enabled = False
        nud19.Enabled = False
        nud20.Enabled = False
        nud21.Enabled = False

        nud1.Minimum = 0
        nud2.Minimum = 0
        nud3.Minimum = 0
        nud4.Minimum = 0
        nud5.Minimum = 0
        nud6.Minimum = 0
        nud7.Minimum = 0
        nud8.Minimum = 0
        nud9.Minimum = 0
        nud10.Minimum = 0
        nud11.Minimum = 0
        nud12.Minimum = 0
        nud13.Minimum = 0
        nud14.Minimum = 0
        nud15.Minimum = 0
        nud16.Minimum = 0
        nud17.Minimum = 0
        nud18.Minimum = 0
        nud19.Minimum = 0
        nud20.Minimum = 0
        nud21.Minimum = 0

        nud1.Value = 0
        nud2.Value = 0
        nud3.Value = 0
        nud4.Value = 0
        nud5.Value = 0
        nud6.Value = 0
        nud7.Value = 0
        nud8.Value = 0
        nud9.Value = 0
        nud10.Value = 0
        nud11.Value = 0
        nud12.Value = 0
        nud13.Value = 0
        nud14.Value = 0
        nud15.Value = 0
        nud16.Value = 0
        nud17.Value = 0
        nud18.Value = 0
        nud19.Value = 0
        nud20.Value = 0
        nud21.Value = 0

        cboMuffin.Enabled = False
        cboJuice.Enabled = False
        cboJuiceS.Enabled = False
        cboMilk.Enabled = False
        cboPop.Enabled = False
        cboPopS.Enabled = False
        cboPTea.Enabled = False
        cboPTeaS.Enabled = False
        cboSmoothie.Enabled = False
        cboSmoothieS.Enabled = False

        cbWYogurt.Enabled = False
        cbWYogurt.Checked = False

        cboMuffin.Text = " -- Flavour --"
        cboJuice.Text = " -- Flavour --"
        cboJuiceS.Text = " -- Size --"
        cboMilk.Text = " -- Flavour --"
        cboPop.Text = " -- Flavour --"
        cboPopS.Text = " -- Size --"
        cboPTea.Text = " -- Flavour --"
        cboPTeaS.Text = " -- Size --"
        cboSmoothie.Text = " -- Flavour --"
        cboSmoothieS.Text = " -- Size --"

        txtCart.Text = Nothing

        btnCalc.Enabled = True
        btnConfirm.Enabled = False
        btnCancel.Enabled = True
        btnCredit.Enabled = False
        btnCash.Enabled = False
        btnDebit.Enabled = False

        lblCalculator.Enabled = False
        lblShow.Enabled = False
        btnC0.Enabled = False
        btnC1.Enabled = False
        btnC2.Enabled = False
        btnC3.Enabled = False
        btnC4.Enabled = False
        btnC5.Enabled = False
        btnC6.Enabled = False
        btnC7.Enabled = False
        btnC8.Enabled = False
        btnC9.Enabled = False
        btnCDecimal.Enabled = False
        btnCBack.Enabled = False
        btnCClear.Enabled = False
        btnCEqual.Enabled = False

        'resets phrases
        phrase = ""
        grandTphrase = vbCrLf & "Your Grand Total is: "
        'clears the entire calc display
        lblShow.Text = ""

        'displays/navigates to/goes back to (enters the) main menu
        Main_Menu.Show()
        'hides this form
        Me.Hide()
    End Sub

    Private Sub btnC1_Click(sender As System.Object, e As System.EventArgs) Handles btnC1.Click
        'calc btn #1
        lblShow.Text = lblShow.Text & "1"
    End Sub

    Private Sub btnC0_Click(sender As System.Object, e As System.EventArgs) Handles btnC0.Click
        'calc btn #0
        lblShow.Text = lblShow.Text & "0"
    End Sub

    Private Sub btnC2_Click(sender As System.Object, e As System.EventArgs) Handles btnC2.Click
        'calc btn #2
        lblShow.Text = lblShow.Text & "2"
    End Sub

    Private Sub btnC3_Click(sender As System.Object, e As System.EventArgs) Handles btnC3.Click
        'calc btn #3
        lblShow.Text = lblShow.Text & "3"
    End Sub

    Private Sub btnC4_Click(sender As System.Object, e As System.EventArgs) Handles btnC4.Click
        'calc btn #4
        lblShow.Text = lblShow.Text & "4"
    End Sub

    Private Sub btnC5_Click(sender As System.Object, e As System.EventArgs) Handles btnC5.Click
        'calc btn #5
        lblShow.Text = lblShow.Text & "5"
    End Sub

    Private Sub btnC6_Click(sender As System.Object, e As System.EventArgs) Handles btnC6.Click
        'calc btn #6
        lblShow.Text = lblShow.Text & "6"
    End Sub

    Private Sub btnC7_Click(sender As System.Object, e As System.EventArgs) Handles btnC7.Click
        'calc btn #7
        lblShow.Text = lblShow.Text & "7"
    End Sub

    Private Sub btnC8_Click(sender As System.Object, e As System.EventArgs) Handles btnC8.Click
        'calc btn #1
        lblShow.Text = lblShow.Text & "8"
    End Sub

    Private Sub btnC9_Click(sender As System.Object, e As System.EventArgs) Handles btnC9.Click
        'calc btn #1
        lblShow.Text = lblShow.Text & "9"
    End Sub

    Private Sub btnCBack_Click(sender As System.Object, e As System.EventArgs) Handles btnCBack.Click
        'takes away (deletes) the last entered character
        lblShow.Text = (lblShow.Text).Substring(0, (((lblShow.Text).Length) - 1))
        'checks if there is already a decimal
        For i = 1 To (lblShow.Text.Length) Step 1
            letter = (lblShow.Text).Substring(i, 1)
            If letter = "." Then
                btnCBack.Enabled = False
            Else
                btnCBack.Enabled = True
            End If
        Next i
    End Sub

    Private Sub btnCClear_Click(sender As System.Object, e As System.EventArgs) Handles btnCClear.Click
        'clears the entire calc display
        lblShow.Text = ""
    End Sub

    Private Sub btnCEqual_Click(sender As System.Object, e As System.EventArgs) Handles btnCEqual.Click
        'calc operation of pay based on pay meth btn
        'opens stream to data file
        inFile = New System.IO.StreamReader("NUMBERS.txt")

        'disable calc sequence of command btns
        lblCalculator.Enabled = False
        lblShow.Enabled = False
        btnC0.Enabled = False
        btnC1.Enabled = False
        btnC2.Enabled = False
        btnC3.Enabled = False
        btnC4.Enabled = False
        btnC5.Enabled = False
        btnC6.Enabled = False
        btnC7.Enabled = False
        btnC8.Enabled = False
        btnC9.Enabled = False
        btnCDecimal.Enabled = False
        btnCBack.Enabled = False
        btnCClear.Enabled = False
        btnCEqual.Enabled = False

        'calc operation of pay based on pay meth btn
        If btnCredit.Enabled = True Then
            'pay by credit

            creditNum = lblShow.Text
            'check for stolen card if out of 4 #s, 1st and last digit is =

            NUM1 = inFile.ReadLine
            NUM2 = inFile.ReadLine
            If creditNum.Substring(0, 1) = creditNum.Substring(3, 1) Then
                MessageBox.Show("ERROR!" & vbTab & "STOLEN CARD DETECTED!" & vbCrLf & "CONTACTING AUTHORITIES NOW", "INVALID - PURCHASE ABORTED")
                'displays (navigates to) arrested form
                Arrested.Show()
                'hides this form
                Me.Hide()
            ElseIf creditNum.Substring(0, 1) = NUM1 And creditNum.Substring(3, 1) = NUM2 Then
                MessageBox.Show("ERROR!" & vbTab & "STOLEN CARD DETECTED!" & vbCrLf & "CONTACTING AUTHORITIES NOW", "INVALID - PURCHASE ABORTED")
                'displays (navigates to) arrested form
                Arrested.Show()
                'hides this form
                Me.Hide()
            Else
                MessageBox.Show("Please remove your card", "VALID - PURCHASE SUCCESSFUL")
                'displays (navigates to) thanks come again form
                Thx.Show()
                'hides this form
                Me.Hide()
            End If

            'close stream to data file
            inFile.Close()

        ElseIf btnDebit.Enabled = True Then
            'pay by debit

            debitNum = lblShow.Text
            'check for stolen card if out of 4 #s, 2nd and 3rd digit is =
            If debitNum.Substring(1, 1) = debitNum.Substring(2, 1) Then
                MessageBox.Show("ERROR!" & vbTab & "STOLEN CARD DETECTED!" & vbCrLf & "CONTACTING AUTHORITIES NOW", "INVALID - PURCHASE ABORTED")
                'displays (navigates to) arrested form
                Arrested.Show()
                'hides this form
                Me.Hide()
            ElseIf debitNum.Substring(1, 1) = NUM1 And debitNum.Substring(2, 1) = NUM2 Then
                MessageBox.Show("ERROR!" & vbTab & "STOLEN CARD DETECTED!" & vbCrLf & "CONTACTING AUTHORITIES NOW", "INVALID - PURCHASE ABORTED")
                'displays (navigates to) arrested form
                Arrested.Show()
                'hides this form
                Me.Hide()
            Else
                MessageBox.Show("Please remove your card", "VALID - PURCHASE SUCCESSFUL")
                'displays (navigates to) thanks come again form
                Thx.Show()
                'hides this form
                Me.Hide()
            End If

            'close stream to data file
            inFile.Close()

        Else
            'pay by cash
            cashPay = lblShow.Text

            'give change
            If cashPay < grandTotal Then
                'insufficient funds
                MessageBox.Show("You're short " & FormatCurrency(grandTotal - cashPay) & "." & vbCrLf & "Sorry, but I'll have to turn you into the authorities", "INSUFFICIENT FUNDS")
                'displays (navigates to) arrested form
                Arrested.Show()
                'hides this form
                Me.Hide()

            Else
                'sufficient funds
                'calc change
                cashChange = cashPay - grandTotal
                changeCounter = cashChange

                If changeCounter >= 20 Then
                    '>=<$20 bills
                    counter20 = changeCounter Mod 20
                    bill20 = (changeCounter - counter20) / 20
                    'compresses into phrase for output
                    changePhrase = changePhrase & bill20 & " $20 bills"
                    ccount += 1
                    changeCounter = changeCounter - bill20 * 20

                    If changeCounter >= 10 Then
                        '=<$10 bills
                        counter10 = changeCounter Mod 10
                        bill10 = (changeCounter - counter10) / 10
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & bill10 & " $10 bills"
                        Else
                            changePhrase = changePhrase & ", " & bill10 & " $10 bills"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - bill10 * 10
                    End If
                    If changeCounter >= 5 Then
                        '=<$5 bills
                        counter5 = changeCounter Mod 5
                        bill5 = (changeCounter - counter5) / 5
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & bill5 & " $5 bills"
                        Else
                            changePhrase = changePhrase & ", " & bill5 & " $5 bills"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - bill5 * 5
                    End If
                    If changeCounter >= 2 Then
                        '=<toonies
                        counter2 = changeCounter Mod 2
                        numToon = (changeCounter - counter2) / 2
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numToon & " toonies"
                        Else
                            changePhrase = changePhrase & ", " & numToon & " toonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numToon * 2
                    End If
                    If changeCounter >= 1 Then
                        '=<loonies
                        counter1 = changeCounter Mod 1
                        numLoon = (changeCounter - counter1) / 1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numLoon & " loonies"
                        Else
                            changePhrase = changePhrase & ", " & numLoon & " loonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numLoon * 1
                    End If
                    If changeCounter >= 0.25 Then
                        '=<quarters
                        counterQ = changeCounter Mod 0.25
                        numQuarter = (changeCounter - counterQ) / 0.25
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numQuarter & " quarters"
                        Else
                            changePhrase = changePhrase & ", " & numQuarter & " quarters"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numQuarter * 0.25
                    End If
                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 10 And ccount = 0 Then
                    '=<$10 bills
                    counter10 = changeCounter Mod 10
                    bill10 = (changeCounter - counter10) / 10
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & bill10 & " $10 bills"
                    Else
                        changePhrase = changePhrase & ", " & bill10 & " $10 bills"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - bill10 * 10

                    If changeCounter >= 5 Then
                        '=<$5 bills
                        counter5 = changeCounter Mod 5
                        bill5 = (changeCounter - counter5) / 5
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & bill5 & " $5 bills"
                        Else
                            changePhrase = changePhrase & ", " & bill5 & " $5 bills"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - bill5 * 5
                    End If
                    If changeCounter >= 2 Then
                        '=<toonies
                        counter2 = changeCounter Mod 2
                        numToon = (changeCounter - counter2) / 2
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numToon & " toonies"
                        Else
                            changePhrase = changePhrase & ", " & numToon & " toonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numToon * 2
                    End If
                    If changeCounter >= 1 Then
                        '=<loonies
                        counter1 = changeCounter Mod 1
                        numLoon = (changeCounter - counter1) / 1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numLoon & " loonies"
                        Else
                            changePhrase = changePhrase & ", " & numLoon & " loonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numLoon * 1
                    End If
                    If changeCounter >= 0.25 Then
                        '=<quarters
                        counterQ = changeCounter Mod 0.25
                        numQuarter = (changeCounter - counterQ) / 0.25
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numQuarter & " quarters"
                        Else
                            changePhrase = changePhrase & ", " & numQuarter & " quarters"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numQuarter * 0.25
                    End If
                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 5 And ccount = 0 Then
                    '=<$5 bills
                    counter5 = changeCounter Mod 5
                    bill5 = (changeCounter - counter5) / 5
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & bill5 & " $5 bills"
                    Else
                        changePhrase = changePhrase & ", " & bill5 & " $5 bills"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - bill5 * 5

                    If changeCounter >= 2 Then
                        '=<toonies
                        counter2 = changeCounter Mod 2
                        numToon = (changeCounter - counter2) / 2
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numToon & " toonies"
                        Else
                            changePhrase = changePhrase & ", " & numToon & " toonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numToon * 2
                    End If
                    If changeCounter >= 1 Then
                        '=<loonies
                        counter1 = changeCounter Mod 1
                        numLoon = (changeCounter - counter1) / 1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numLoon & " loonies"
                        Else
                            changePhrase = changePhrase & ", " & numLoon & " loonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numLoon * 1
                    End If
                    If changeCounter >= 0.25 Then
                        '=<quarters
                        counterQ = changeCounter Mod 0.25
                        numQuarter = (changeCounter - counterQ) / 0.25
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numQuarter & " quarters"
                        Else
                            changePhrase = changePhrase & ", " & numQuarter & " quarters"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numQuarter * 0.25
                    End If
                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 2 And ccount = 0 Then
                    '=<toonies
                    counter2 = changeCounter Mod 2
                    numToon = (changeCounter - counter2) / 2
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & numToon & " toonies"
                    Else
                        changePhrase = changePhrase & ", " & numToon & " toonies"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - numToon * 2

                    If changeCounter >= 1 Then
                        '=<loonies
                        counter1 = changeCounter Mod 1
                        numLoon = (changeCounter - counter1) / 1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numLoon & " loonies"
                        Else
                            changePhrase = changePhrase & ", " & numLoon & " loonies"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numLoon * 1
                    End If
                    If changeCounter >= 0.25 Then
                        '=<quarters
                        counterQ = changeCounter Mod 0.25
                        numQuarter = (changeCounter - counterQ) / 0.25
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numQuarter & " quarters"
                        Else
                            changePhrase = changePhrase & ", " & numQuarter & " quarters"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numQuarter * 0.25
                    End If
                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 1 And ccount = 0 Then
                    '=<loonies
                    counter1 = changeCounter Mod 1
                    numLoon = (changeCounter - counter1) / 1
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & numLoon & " loonies"
                    Else
                        changePhrase = changePhrase & ", " & numLoon & " loonies"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - numLoon * 1

                    If changeCounter >= 0.25 Then
                        '=<quarters
                        counterQ = changeCounter Mod 0.25
                        numQuarter = (changeCounter - counterQ) / 0.25
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numQuarter & " quarters"
                        Else
                            changePhrase = changePhrase & ", " & numQuarter & " quarters"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numQuarter * 0.25
                    End If
                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 0.25 And ccount = 0 Then
                    '=<quarters
                    counterQ = changeCounter Mod 0.25
                    numQuarter = (changeCounter - counterQ) / 0.25
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & numQuarter & " quarters"
                    Else
                        changePhrase = changePhrase & ", " & numQuarter & " quarters"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - numQuarter * 0.25

                    If changeCounter >= 0.1 Then
                        '=<dimes
                        counterD = changeCounter Mod 0.1
                        numDime = (changeCounter - counterD) / 0.1
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numDime & " dimes"
                        Else
                            changePhrase = changePhrase & ", " & numDime & " dimes"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numDime * 0.1
                    End If
                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 0.1 And ccount = 0 Then
                    '=<dimes
                    counterD = changeCounter Mod 0.1
                    numDime = (changeCounter - counterD) / 0.1
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & numDime & " dimes"
                    Else
                        changePhrase = changePhrase & ", " & numDime & " dimes"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - numDime * 0.1

                    If changeCounter >= 0.05 Then
                        '=<nickels
                        counterN = changeCounter Mod 0.05
                        numNickel = (changeCounter - counterN) / 0.05
                        'compresses into phrase for output
                        If ccount = 0 Then
                            changePhrase = changePhrase & numNickel & " nickels"
                        Else
                            changePhrase = changePhrase & ", " & numNickel & " nickels"
                        End If
                        ccount += 1
                        changeCounter = changeCounter - numNickel * 0.05
                    End If
                End If

                If cashChange >= 0.05 And ccount = 0 Then
                    '=<nickels
                    counterN = changeCounter Mod 0.05
                    numNickel = (changeCounter - counterN) / 0.05
                    'compresses into phrase for output
                    If ccount = 0 Then
                        changePhrase = changePhrase & numNickel & " nickels"
                    Else
                        changePhrase = changePhrase & ", " & numNickel & " nickels"
                    End If
                    ccount += 1
                    changeCounter = changeCounter - numNickel * 0.05
                End If


                '< pennies
                counterP = changeCounter Mod 0.01
                numPenny = (changeCounter - counterP) / 0.01
                'compresses into phrase for output
                If ccount = 0 Then
                    changePhrase = changePhrase & numPenny & " pennies"
                Else
                    changePhrase = changePhrase & ", " & numPenny & " pennies"
                End If
                ccount += 1
                changeCounter = changeCounter - numPenny * 0.01


                MessageBox.Show("Here is your change: " & FormatCurrency(cashChange) & vbCrLf & vbTab & "(The cashier hands you:" & vbCrLf & changePhrase, "YOUR CHANGE")

                'displays (navigates to) thanks come again form
                Thx.Show()
                'hides this form
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnCDecimal_Click(sender As System.Object, e As System.EventArgs) Handles btnCDecimal.Click
        'places decimal
        lblShow.Text = lblShow.Text & "."
        'disables this btn
        btnCDecimal.Enabled = False
    End Sub

    Private Sub cboSmoothieS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSmoothieS.SelectedIndexChanged
        'changes the size of the beverage
        'changes the price in correlation to the size
        If cboSmoothieS.Text = "Small" Then
            lblCost21.Text = "$2.50"
        ElseIf cboSmoothieS.Text = "Large" Then
            lblCost21.Text = "$3.50"
        Else
            'cboSmoothieS.Text = "Regular"
            lblCost21.Text = "$3.00"
        End If
    End Sub

    Private Sub cboPTeaS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPTeaS.SelectedIndexChanged
        'changes the size of the beverage
        'changes the price in correlation to the size
        If cboPTeaS.Text = "Regular" Then
            lblCost19.Text = "$1.50"
        ElseIf cboPTeaS.Text = "Large" Then
            lblCost19.Text = "$2.00"
        Else
            'cboPTeaS.Text = "Small"
            lblCost19.Text = "$1.00"
        End If
    End Sub

    Private Sub cboPopS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPopS.SelectedIndexChanged
        'changes the size of the beverage
        'changes the price in correlation to the size

        'DOLLAR DRINK DAYS === ALWAYS $1.00

    End Sub

    Private Sub cboJuiceS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboJuiceS.SelectedIndexChanged
        'changes the size of the beverage
        'changes the price in correlation to the size
        If cboJuiceS.Text = "Small" Then
            lblCost16.Text = "$1.00"
        ElseIf cboJuiceS.Text = "Large" Then
            lblCost16.Text = "$2.00"
        Else
            'cboJuiceS.Text = "Regular"
            lblCost16.Text = "$1.50"
        End If
    End Sub
End Class
