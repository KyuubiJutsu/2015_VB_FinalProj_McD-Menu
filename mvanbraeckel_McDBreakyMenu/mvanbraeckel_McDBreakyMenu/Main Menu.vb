Public Class Main_Menu
    'Mitchell Van Braeckel
    '04/06/2015
    'Menu selection and order pay calculator for McDonald

    '.

    Private Sub btnEnterMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMenu.Click
        'displays/navigates to (enters the) mcd breaky menu
        McDonald_Breaky_Menu.Show()
        'hides this form
        Me.Hide()
    End Sub
End Class