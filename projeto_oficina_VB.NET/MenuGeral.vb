Public Class MenuGeral
    Private Sub Menugeraldois_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubmenu()
    End Sub
    Private Sub HideSubmenu()
        Panel_clientes.Visible = False
        Panel_checklist.Visible = False
        Panel_orcamentos.Visible = False
        Panel_veiculos.Visible = False

    End Sub
    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            HideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        showsubmenu(Panel_clientes)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        showsubmenu(Panel_veiculos)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        showsubmenu(Panel_orcamentos)
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        showsubmenu(Panel_checklist)
    End Sub
End Class