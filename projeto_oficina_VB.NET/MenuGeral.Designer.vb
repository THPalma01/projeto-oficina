<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGeral
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGeral))
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.header = New System.Windows.Forms.Panel()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.btn_return = New Guna.UI.WinForms.GunaImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.sidepanel = New Guna.UI.WinForms.GunaLinePanel()
        Me.BunifuFlatButton12 = New ns1.BunifuFlatButton()
        Me.Panel_checklist = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton10 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton11 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton9 = New ns1.BunifuFlatButton()
        Me.Panel_orcamentos = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton8 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton6 = New ns1.BunifuFlatButton()
        Me.Panel_veiculos = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton4 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton5 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        Me.Panel_clientes = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.btn_clientes = New ns1.BunifuFlatButton()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.header.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        Me.Panel_checklist.SuspendLayout()
        Me.Panel_orcamentos.SuspendLayout()
        Me.Panel_veiculos.SuspendLayout()
        Me.Panel_clientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.header.Controls.Add(Me.GunaImageButton2)
        Me.header.Controls.Add(Me.btn_return)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(275, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(675, 103)
        Me.header.TabIndex = 1
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaImageButton2.Image = CType(resources.GetObject("GunaImageButton2.Image"), System.Drawing.Image)
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(78, 103)
        Me.GunaImageButton2.TabIndex = 2
        '
        'btn_return
        '
        Me.btn_return.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_return.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_return.Location = New System.Drawing.Point(600, 0)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.OnHoverImage = Nothing
        Me.btn_return.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_return.Size = New System.Drawing.Size(75, 103)
        Me.btn_return.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 103)
        Me.Panel1.TabIndex = 5
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(3, 10)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(90, 75)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(99, 28)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(113, 42)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Menu"
        '
        'sidepanel
        '
        Me.sidepanel.AutoScroll = True
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.BunifuFlatButton12)
        Me.sidepanel.Controls.Add(Me.Panel_checklist)
        Me.sidepanel.Controls.Add(Me.BunifuFlatButton9)
        Me.sidepanel.Controls.Add(Me.Panel_orcamentos)
        Me.sidepanel.Controls.Add(Me.BunifuFlatButton6)
        Me.sidepanel.Controls.Add(Me.Panel_veiculos)
        Me.sidepanel.Controls.Add(Me.BunifuFlatButton3)
        Me.sidepanel.Controls.Add(Me.Panel_clientes)
        Me.sidepanel.Controls.Add(Me.btn_clientes)
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.LineColor = System.Drawing.Color.Black
        Me.sidepanel.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(275, 600)
        Me.sidepanel.TabIndex = 0
        '
        'BunifuFlatButton12
        '
        Me.BunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton12.BorderRadius = 0
        Me.BunifuFlatButton12.ButtonText = "Peças e Serviços"
        Me.BunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton12.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton12.Iconimage = CType(resources.GetObject("BunifuFlatButton12.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton12.Iconimage_right = Nothing
        Me.BunifuFlatButton12.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton12.Iconimage_Selected = Nothing
        Me.BunifuFlatButton12.IconMarginLeft = 0
        Me.BunifuFlatButton12.IconMarginRight = 0
        Me.BunifuFlatButton12.IconRightVisible = True
        Me.BunifuFlatButton12.IconRightZoom = 0R
        Me.BunifuFlatButton12.IconVisible = True
        Me.BunifuFlatButton12.IconZoom = 90.0R
        Me.BunifuFlatButton12.IsTab = False
        Me.BunifuFlatButton12.Location = New System.Drawing.Point(0, 739)
        Me.BunifuFlatButton12.Name = "BunifuFlatButton12"
        Me.BunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton12.selected = False
        Me.BunifuFlatButton12.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton12.TabIndex = 14
        Me.BunifuFlatButton12.Text = "Peças e Serviços"
        Me.BunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton12.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton12.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel_checklist
        '
        Me.Panel_checklist.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_checklist.Controls.Add(Me.BunifuFlatButton10)
        Me.Panel_checklist.Controls.Add(Me.BunifuFlatButton11)
        Me.Panel_checklist.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_checklist.Location = New System.Drawing.Point(0, 628)
        Me.Panel_checklist.Name = "Panel_checklist"
        Me.Panel_checklist.Size = New System.Drawing.Size(258, 111)
        Me.Panel_checklist.TabIndex = 13
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "Visualizar checklist"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = CType(resources.GetObject("BunifuFlatButton10.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 90.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(0, 48)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = False
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton10.TabIndex = 2
        Me.BunifuFlatButton10.Text = "Visualizar checklist"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.ButtonText = "Novo checklist"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = CType(resources.GetObject("BunifuFlatButton11.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = True
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = True
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton11.TabIndex = 7
        Me.BunifuFlatButton11.Text = "Novo checklist"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "Checklists"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 90.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(0, 580)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton9.TabIndex = 12
        Me.BunifuFlatButton9.Text = "Checklists"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel_orcamentos
        '
        Me.Panel_orcamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_orcamentos.Controls.Add(Me.BunifuFlatButton7)
        Me.Panel_orcamentos.Controls.Add(Me.BunifuFlatButton8)
        Me.Panel_orcamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_orcamentos.Location = New System.Drawing.Point(0, 469)
        Me.Panel_orcamentos.Name = "Panel_orcamentos"
        Me.Panel_orcamentos.Size = New System.Drawing.Size(258, 111)
        Me.Panel_orcamentos.TabIndex = 11
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Visualizar orçamentos"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 48)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton7.TabIndex = 2
        Me.BunifuFlatButton7.Text = "Visualizar orçamentos"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "Novo orçamento"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton8.TabIndex = 7
        Me.BunifuFlatButton8.Text = "Novo orçamento"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Orçamentos"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 421)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton6.TabIndex = 10
        Me.BunifuFlatButton6.Text = "Orçamentos"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel_veiculos
        '
        Me.Panel_veiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_veiculos.Controls.Add(Me.BunifuFlatButton4)
        Me.Panel_veiculos.Controls.Add(Me.BunifuFlatButton5)
        Me.Panel_veiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_veiculos.Location = New System.Drawing.Point(0, 310)
        Me.Panel_veiculos.Name = "Panel_veiculos"
        Me.Panel_veiculos.Size = New System.Drawing.Size(258, 111)
        Me.Panel_veiculos.TabIndex = 9
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Visualizar Veiculos"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 48)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton4.TabIndex = 2
        Me.BunifuFlatButton4.Text = "Visualizar Veiculos"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Cadastrar Veiculos"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton5.TabIndex = 7
        Me.BunifuFlatButton5.Text = "Cadastrar Veiculos"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Veiculos"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 262)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton3.TabIndex = 8
        Me.BunifuFlatButton3.Text = "Veiculos"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel_clientes
        '
        Me.Panel_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_clientes.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel_clientes.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_clientes.Location = New System.Drawing.Point(0, 151)
        Me.Panel_clientes.Name = "Panel_clientes"
        Me.Panel_clientes.Size = New System.Drawing.Size(258, 111)
        Me.Panel_clientes.TabIndex = 7
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Visualizar Clientes"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 48)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "Visualizar Clientes"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Cadastrar Clientes"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(258, 48)
        Me.BunifuFlatButton2.TabIndex = 7
        Me.BunifuFlatButton2.Text = "Cadastrar Clientes"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btn_clientes
        '
        Me.btn_clientes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clientes.BorderRadius = 0
        Me.btn_clientes.ButtonText = "Clientes"
        Me.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clientes.DisabledColor = System.Drawing.Color.Gray
        Me.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_clientes.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_clientes.Iconimage = CType(resources.GetObject("btn_clientes.Iconimage"), System.Drawing.Image)
        Me.btn_clientes.Iconimage_right = Nothing
        Me.btn_clientes.Iconimage_right_Selected = Nothing
        Me.btn_clientes.Iconimage_Selected = Nothing
        Me.btn_clientes.IconMarginLeft = 0
        Me.btn_clientes.IconMarginRight = 0
        Me.btn_clientes.IconRightVisible = True
        Me.btn_clientes.IconRightZoom = 0R
        Me.btn_clientes.IconVisible = True
        Me.btn_clientes.IconZoom = 90.0R
        Me.btn_clientes.IsTab = False
        Me.btn_clientes.Location = New System.Drawing.Point(0, 103)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_clientes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_clientes.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_clientes.selected = False
        Me.btn_clientes.Size = New System.Drawing.Size(258, 48)
        Me.btn_clientes.TabIndex = 6
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Textcolor = System.Drawing.Color.White
        Me.btn_clientes.TextFont = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(275, 103)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(675, 497)
        Me.GunaGradient2Panel1.TabIndex = 2
        '
        'MenuGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "MenuGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGeral"
        Me.header.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        Me.Panel_checklist.ResumeLayout(False)
        Me.Panel_orcamentos.ResumeLayout(False)
        Me.Panel_veiculos.ResumeLayout(False)
        Me.Panel_clientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents header As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents sidepanel As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Panel_clientes As Panel
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents btn_clientes As ns1.BunifuFlatButton
    Friend WithEvents Panel_orcamentos As Panel
    Friend WithEvents BunifuFlatButton7 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As ns1.BunifuFlatButton
    Friend WithEvents Panel_veiculos As Panel
    Friend WithEvents BunifuFlatButton4 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton12 As ns1.BunifuFlatButton
    Friend WithEvents Panel_checklist As Panel
    Friend WithEvents BunifuFlatButton10 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton11 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As ns1.BunifuFlatButton
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents btn_return As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
End Class
