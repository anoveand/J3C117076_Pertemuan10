<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.txtfakt = New System.Windows.Forms.TextBox()
        Me.txtfibo = New System.Windows.Forms.TextBox()
        Me.txtkuad = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.txtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtkuad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtfibo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtfakt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(74, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil Perhitungan Deret"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Faktorial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fibonacci"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kuadrat"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(101, 36)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(126, 20)
        Me.txtn.TabIndex = 1
        '
        'txtfakt
        '
        Me.txtfakt.Location = New System.Drawing.Point(101, 36)
        Me.txtfakt.Name = "txtfakt"
        Me.txtfakt.Size = New System.Drawing.Size(201, 20)
        Me.txtfakt.TabIndex = 2
        '
        'txtfibo
        '
        Me.txtfibo.Location = New System.Drawing.Point(101, 80)
        Me.txtfibo.Name = "txtfibo"
        Me.txtfibo.Size = New System.Drawing.Size(201, 20)
        Me.txtfibo.TabIndex = 3
        '
        'txtkuad
        '
        Me.txtkuad.Location = New System.Drawing.Point(101, 122)
        Me.txtkuad.Name = "txtkuad"
        Me.txtkuad.Size = New System.Drawing.Size(201, 20)
        Me.txtkuad.TabIndex = 4
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(249, 31)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(88, 28)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Hitung"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 373)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents txtkuad As System.Windows.Forms.TextBox
    Friend WithEvents txtfibo As System.Windows.Forms.TextBox
    Friend WithEvents txtfakt As System.Windows.Forms.TextBox
End Class
