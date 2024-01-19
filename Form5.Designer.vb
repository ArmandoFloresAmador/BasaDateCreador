<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtxMinimizar = New System.Windows.Forms.PictureBox()
        Me.PtxCerrar = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.PtxMinimizar)
        Me.Panel1.Controls.Add(Me.PtxCerrar)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 38)
        Me.Panel1.TabIndex = 5
        '
        'PtxMinimizar
        '
        Me.PtxMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.PtxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxMinimizar.Image = CType(resources.GetObject("PtxMinimizar.Image"), System.Drawing.Image)
        Me.PtxMinimizar.Location = New System.Drawing.Point(714, 4)
        Me.PtxMinimizar.Name = "PtxMinimizar"
        Me.PtxMinimizar.Size = New System.Drawing.Size(34, 31)
        Me.PtxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxMinimizar.TabIndex = 2
        Me.PtxMinimizar.TabStop = False
        '
        'PtxCerrar
        '
        Me.PtxCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PtxCerrar.Image = CType(resources.GetObject("PtxCerrar.Image"), System.Drawing.Image)
        Me.PtxCerrar.Location = New System.Drawing.Point(754, 3)
        Me.PtxCerrar.Name = "PtxCerrar"
        Me.PtxCerrar.Size = New System.Drawing.Size(34, 32)
        Me.PtxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxCerrar.TabIndex = 0
        Me.PtxCerrar.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(576, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(692, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Continuar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Contraseña"
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(128, 82)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(368, 20)
        Me.Text1.TabIndex = 12
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(128, 129)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(370, 20)
        Me.Text2.TabIndex = 13
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(128, 174)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(370, 20)
        Me.Text3.TabIndex = 14
        '
        'Text4
        '
        Me.Text4.Location = New System.Drawing.Point(128, 219)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(370, 20)
        Me.Text4.TabIndex = 15
        '
        'Text5
        '
        Me.Text5.Location = New System.Drawing.Point(128, 256)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(370, 20)
        Me.Text5.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Años"
        '
        'Text6
        '
        Me.Text6.Location = New System.Drawing.Point(128, 294)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(370, 20)
        Me.Text6.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Correo"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Text6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Text5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PtxMinimizar As PictureBox
    Friend WithEvents PtxCerrar As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Text6 As TextBox
    Friend WithEvents Label6 As Label
End Class
