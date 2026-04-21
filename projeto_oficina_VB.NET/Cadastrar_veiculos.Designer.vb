<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastrar_veiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastrar_veiculos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_checklist = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_ajuda = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_orcamentos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_visu_veiculos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.Label()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.btn_excluir = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_editar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_salvar = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Header = New System.Windows.Forms.Panel()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.btn_return = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaSeparator6 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator5 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator4 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.cmb_marcas = New ns1.BunifuDropdown()
        Me.cmb_clientes = New ns1.BunifuDropdown()
        Me.BunifuCustomLabel11 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.GunaLineTextBox5 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New ns1.BunifuCustomLabel()
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuCustomLabel9 = New ns1.BunifuCustomLabel()
        Me.GunaLineTextBox3 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuCustomLabel8 = New ns1.BunifuCustomLabel()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_checklist)
        Me.Panel1.Controls.Add(Me.btn_ajuda)
        Me.Panel1.Controls.Add(Me.btn_orcamentos)
        Me.Panel1.Controls.Add(Me.btn_visu_veiculos)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 662)
        Me.Panel1.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 580)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(303, 82)
        Me.Panel5.TabIndex = 12
        '
        'btn_checklist
        '
        Me.btn_checklist.AnimationHoverSpeed = 0.07!
        Me.btn_checklist.AnimationSpeed = 0.03!
        Me.btn_checklist.BackColor = System.Drawing.Color.Transparent
        Me.btn_checklist.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_checklist.BorderColor = System.Drawing.Color.Black
        Me.btn_checklist.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_checklist.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_checklist.CheckedForeColor = System.Drawing.Color.White
        Me.btn_checklist.CheckedImage = CType(resources.GetObject("btn_checklist.CheckedImage"), System.Drawing.Image)
        Me.btn_checklist.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_checklist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_checklist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_checklist.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_checklist.ForeColor = System.Drawing.Color.White
        Me.btn_checklist.Image = CType(resources.GetObject("btn_checklist.Image"), System.Drawing.Image)
        Me.btn_checklist.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_checklist.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_checklist.Location = New System.Drawing.Point(14, 235)
        Me.btn_checklist.Name = "btn_checklist"
        Me.btn_checklist.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_checklist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_checklist.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_checklist.OnHoverImage = Nothing
        Me.btn_checklist.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_checklist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_checklist.Radius = 10
        Me.btn_checklist.Size = New System.Drawing.Size(269, 49)
        Me.btn_checklist.TabIndex = 11
        Me.btn_checklist.Text = "Ir para checklist"
        Me.btn_checklist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ajuda
        '
        Me.btn_ajuda.AnimationHoverSpeed = 0.07!
        Me.btn_ajuda.AnimationSpeed = 0.03!
        Me.btn_ajuda.BackColor = System.Drawing.Color.Transparent
        Me.btn_ajuda.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ajuda.BorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_ajuda.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.CheckedForeColor = System.Drawing.Color.White
        Me.btn_ajuda.CheckedImage = CType(resources.GetObject("btn_ajuda.CheckedImage"), System.Drawing.Image)
        Me.btn_ajuda.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_ajuda.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ajuda.FocusedColor = System.Drawing.Color.Empty
        Me.btn_ajuda.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ajuda.ForeColor = System.Drawing.Color.White
        Me.btn_ajuda.Image = CType(resources.GetObject("btn_ajuda.Image"), System.Drawing.Image)
        Me.btn_ajuda.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_ajuda.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ajuda.Location = New System.Drawing.Point(15, 396)
        Me.btn_ajuda.Name = "btn_ajuda"
        Me.btn_ajuda.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ajuda.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ajuda.OnHoverImage = Nothing
        Me.btn_ajuda.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ajuda.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ajuda.Radius = 10
        Me.btn_ajuda.Size = New System.Drawing.Size(268, 49)
        Me.btn_ajuda.TabIndex = 10
        Me.btn_ajuda.Text = "Ajuda"
        Me.btn_ajuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_orcamentos
        '
        Me.btn_orcamentos.AnimationHoverSpeed = 0.07!
        Me.btn_orcamentos.AnimationSpeed = 0.03!
        Me.btn_orcamentos.BackColor = System.Drawing.Color.Transparent
        Me.btn_orcamentos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_orcamentos.BorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_orcamentos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.CheckedImage = CType(resources.GetObject("btn_orcamentos.CheckedImage"), System.Drawing.Image)
        Me.btn_orcamentos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_orcamentos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_orcamentos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_orcamentos.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_orcamentos.ForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.Image = CType(resources.GetObject("btn_orcamentos.Image"), System.Drawing.Image)
        Me.btn_orcamentos.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_orcamentos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_orcamentos.Location = New System.Drawing.Point(14, 313)
        Me.btn_orcamentos.Name = "btn_orcamentos"
        Me.btn_orcamentos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_orcamentos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.OnHoverImage = Nothing
        Me.btn_orcamentos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_orcamentos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_orcamentos.Radius = 10
        Me.btn_orcamentos.Size = New System.Drawing.Size(265, 49)
        Me.btn_orcamentos.TabIndex = 9
        Me.btn_orcamentos.Text = "Ir para orçamento"
        Me.btn_orcamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_visu_veiculos
        '
        Me.btn_visu_veiculos.AnimationHoverSpeed = 0.07!
        Me.btn_visu_veiculos.AnimationSpeed = 0.03!
        Me.btn_visu_veiculos.BackColor = System.Drawing.Color.Transparent
        Me.btn_visu_veiculos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_visu_veiculos.BorderColor = System.Drawing.Color.Black
        Me.btn_visu_veiculos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_visu_veiculos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_visu_veiculos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_visu_veiculos.CheckedImage = CType(resources.GetObject("btn_visu_veiculos.CheckedImage"), System.Drawing.Image)
        Me.btn_visu_veiculos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_visu_veiculos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_visu_veiculos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_visu_veiculos.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_visu_veiculos.ForeColor = System.Drawing.Color.White
        Me.btn_visu_veiculos.Image = CType(resources.GetObject("btn_visu_veiculos.Image"), System.Drawing.Image)
        Me.btn_visu_veiculos.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_visu_veiculos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_visu_veiculos.Location = New System.Drawing.Point(18, 162)
        Me.btn_visu_veiculos.Name = "btn_visu_veiculos"
        Me.btn_visu_veiculos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_visu_veiculos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_visu_veiculos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_visu_veiculos.OnHoverImage = Nothing
        Me.btn_visu_veiculos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_visu_veiculos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_visu_veiculos.Radius = 10
        Me.btn_visu_veiculos.Size = New System.Drawing.Size(265, 49)
        Me.btn_visu_veiculos.TabIndex = 8
        Me.btn_visu_veiculos.Text = "Visualizar veiculos"
        Me.btn_visu_veiculos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel2.Controls.Add(Me.logo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 100)
        Me.Panel2.TabIndex = 4
        '
        'logo
        '
        Me.logo.AutoSize = True
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(194, 84)
        Me.logo.TabIndex = 4
        Me.logo.Text = "Cadastrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "veículos"
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_excluir)
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_editar)
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_salvar)
        Me.GunaGradient2Panel1.Controls.Add(Me.Panel3)
        Me.GunaGradient2Panel1.Controls.Add(Me.Header)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaGradientPanel1)
        Me.GunaGradient2Panel1.Controls.Add(Me.Panel1)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(1187, 662)
        Me.GunaGradient2Panel1.TabIndex = 3
        '
        'btn_excluir
        '
        Me.btn_excluir.Animated = True
        Me.btn_excluir.AnimationHoverSpeed = 0.07!
        Me.btn_excluir.AnimationSpeed = 0.03!
        Me.btn_excluir.BaseColor = System.Drawing.Color.Transparent
        Me.btn_excluir.BorderColor = System.Drawing.Color.Black
        Me.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_excluir.FocusedColor = System.Drawing.Color.Empty
        Me.btn_excluir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_excluir.ForeColor = System.Drawing.Color.White
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_excluir.Location = New System.Drawing.Point(1077, 347)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_excluir.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_excluir.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_excluir.OnHoverImage = Nothing
        Me.btn_excluir.OnPressedColor = System.Drawing.Color.Black
        Me.btn_excluir.Size = New System.Drawing.Size(98, 82)
        Me.btn_excluir.TabIndex = 20
        Me.btn_excluir.Text = "Excluir"
        '
        'btn_editar
        '
        Me.btn_editar.Animated = True
        Me.btn_editar.AnimationHoverSpeed = 0.07!
        Me.btn_editar.AnimationSpeed = 0.03!
        Me.btn_editar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_editar.BorderColor = System.Drawing.Color.Black
        Me.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_editar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_editar.Location = New System.Drawing.Point(1077, 257)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_editar.OnHoverImage = Nothing
        Me.btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_editar.Size = New System.Drawing.Size(98, 79)
        Me.btn_editar.TabIndex = 21
        Me.btn_editar.Text = "Editar"
        '
        'btn_salvar
        '
        Me.btn_salvar.Animated = True
        Me.btn_salvar.AnimationHoverSpeed = 0.07!
        Me.btn_salvar.AnimationSpeed = 0.03!
        Me.btn_salvar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salvar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salvar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_salvar.Location = New System.Drawing.Point(1077, 162)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Size = New System.Drawing.Size(98, 76)
        Me.btn_salvar.TabIndex = 19
        Me.btn_salvar.Text = "Salvar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(303, 580)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(884, 82)
        Me.Panel3.TabIndex = 18
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header.Controls.Add(Me.GunaImageButton2)
        Me.Header.Controls.Add(Me.btn_return)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(303, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(884, 100)
        Me.Header.TabIndex = 17
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaImageButton2.Image = CType(resources.GetObject("GunaImageButton2.Image"), System.Drawing.Image)
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(78, 100)
        Me.GunaImageButton2.TabIndex = 1
        '
        'btn_return
        '
        Me.btn_return.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_return.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_return.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_return.Location = New System.Drawing.Point(809, 0)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.OnHoverImage = Nothing
        Me.btn_return.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_return.Size = New System.Drawing.Size(75, 100)
        Me.btn_return.TabIndex = 0
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator6)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator5)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator4)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator3)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaSeparator1)
        Me.GunaGradientPanel1.Controls.Add(Me.cmb_marcas)
        Me.GunaGradientPanel1.Controls.Add(Me.cmb_clientes)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel11)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLineTextBox5)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLineTextBox4)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLineTextBox3)
        Me.GunaGradientPanel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLineTextBox1)
        Me.GunaGradientPanel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(309, 106)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(659, 469)
        Me.GunaGradientPanel1.TabIndex = 16
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaSeparator6
        '
        Me.GunaSeparator6.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator6.Location = New System.Drawing.Point(258, 130)
        Me.GunaSeparator6.Name = "GunaSeparator6"
        Me.GunaSeparator6.Size = New System.Drawing.Size(67, 10)
        Me.GunaSeparator6.TabIndex = 21
        '
        'GunaSeparator5
        '
        Me.GunaSeparator5.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator5.Location = New System.Drawing.Point(258, 313)
        Me.GunaSeparator5.Name = "GunaSeparator5"
        Me.GunaSeparator5.Size = New System.Drawing.Size(123, 10)
        Me.GunaSeparator5.TabIndex = 20
        '
        'GunaSeparator4
        '
        Me.GunaSeparator4.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator4.Location = New System.Drawing.Point(258, 228)
        Me.GunaSeparator4.Name = "GunaSeparator4"
        Me.GunaSeparator4.Size = New System.Drawing.Size(76, 10)
        Me.GunaSeparator4.TabIndex = 19
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator3.Location = New System.Drawing.Point(491, 56)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(138, 10)
        Me.GunaSeparator3.TabIndex = 18
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(258, 56)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(72, 10)
        Me.GunaSeparator2.TabIndex = 17
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(23, 56)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(72, 10)
        Me.GunaSeparator1.TabIndex = 16
        '
        'cmb_marcas
        '
        Me.cmb_marcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmb_marcas.BorderRadius = 3
        Me.cmb_marcas.ForeColor = System.Drawing.Color.White
        Me.cmb_marcas.Items = New String(-1) {}
        Me.cmb_marcas.Location = New System.Drawing.Point(257, 143)
        Me.cmb_marcas.Margin = New System.Windows.Forms.Padding(16, 13, 16, 13)
        Me.cmb_marcas.Name = "cmb_marcas"
        Me.cmb_marcas.NomalColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmb_marcas.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmb_marcas.selectedIndex = -1
        Me.cmb_marcas.Size = New System.Drawing.Size(183, 35)
        Me.cmb_marcas.TabIndex = 15
        '
        'cmb_clientes
        '
        Me.cmb_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmb_clientes.BorderRadius = 3
        Me.cmb_clientes.ForeColor = System.Drawing.Color.White
        Me.cmb_clientes.Items = New String(-1) {}
        Me.cmb_clientes.Location = New System.Drawing.Point(23, 70)
        Me.cmb_clientes.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cmb_clientes.Name = "cmb_clientes"
        Me.cmb_clientes.NomalColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmb_clientes.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmb_clientes.selectedIndex = -1
        Me.cmb_clientes.Size = New System.Drawing.Size(183, 35)
        Me.cmb_clientes.TabIndex = 14
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(19, 37)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(76, 23)
        Me.BunifuCustomLabel11.TabIndex = 13
        Me.BunifuCustomLabel11.Text = "Cliente"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(475, 117)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(0, 23)
        Me.BunifuCustomLabel6.TabIndex = 11
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(254, 290)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(127, 23)
        Me.BunifuCustomLabel5.TabIndex = 9
        Me.BunifuCustomLabel5.Text = "Ano/Modelo"
        '
        'GunaLineTextBox5
        '
        Me.GunaLineTextBox5.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox5.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaLineTextBox5.Location = New System.Drawing.Point(257, 329)
        Me.GunaLineTextBox5.Name = "GunaLineTextBox5"
        Me.GunaLineTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox5.SelectedText = ""
        Me.GunaLineTextBox5.Size = New System.Drawing.Size(183, 26)
        Me.GunaLineTextBox5.TabIndex = 8
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(253, 207)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(81, 23)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "Modelo"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(487, 37)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(142, 23)
        Me.BunifuCustomLabel10.TabIndex = 5
        Me.BunifuCustomLabel10.Text = "Kilometragem"
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(257, 244)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.SelectedText = ""
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(183, 26)
        Me.GunaLineTextBox4.TabIndex = 6
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(254, 109)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(71, 23)
        Me.BunifuCustomLabel9.TabIndex = 3
        Me.BunifuCustomLabel9.Text = "Marca"
        '
        'GunaLineTextBox3
        '
        Me.GunaLineTextBox3.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaLineTextBox3.Location = New System.Drawing.Point(491, 74)
        Me.GunaLineTextBox3.Name = "GunaLineTextBox3"
        Me.GunaLineTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox3.SelectedText = ""
        Me.GunaLineTextBox3.Size = New System.Drawing.Size(160, 26)
        Me.GunaLineTextBox3.TabIndex = 4
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(250, 37)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(80, 23)
        Me.BunifuCustomLabel8.TabIndex = 1
        Me.BunifuCustomLabel8.Text = "Veículo"
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(258, 74)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.SelectedText = ""
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(182, 26)
        Me.GunaLineTextBox1.TabIndex = 0
        '
        'Cadastrar_veiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 662)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cadastrar_veiculos"
        Me.Text = "Cadastrar_veiculos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_checklist As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_ajuda As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_orcamentos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_visu_veiculos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuCustomLabel6 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents GunaLineTextBox5 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox3 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents logo As Label
    Friend WithEvents cmb_marcas As ns1.BunifuDropdown
    Friend WithEvents cmb_clientes As ns1.BunifuDropdown
    Friend WithEvents BunifuCustomLabel11 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As ns1.BunifuCustomLabel
    Friend WithEvents Header As Panel
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btn_return As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_excluir As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_editar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaSeparator6 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator5 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator4 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
End Class
