<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbtgl = New System.Windows.Forms.ComboBox()
        Me.cbbln = New System.Windows.Forms.ComboBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btncek = New System.Windows.Forms.Button()
        Me.btnbersihkan = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HADIAH MENURUT BULAN LAHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bulan lahir"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(134, 71)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(137, 20)
        Me.txtnama.TabIndex = 4
        '
        'cbtgl
        '
        Me.cbtgl.FormattingEnabled = True
        Me.cbtgl.Location = New System.Drawing.Point(134, 105)
        Me.cbtgl.Name = "cbtgl"
        Me.cbtgl.Size = New System.Drawing.Size(137, 21)
        Me.cbtgl.TabIndex = 5
        '
        'cbbln
        '
        Me.cbbln.FormattingEnabled = True
        Me.cbbln.Location = New System.Drawing.Point(134, 140)
        Me.cbbln.Name = "cbbln"
        Me.cbbln.Size = New System.Drawing.Size(137, 21)
        Me.cbbln.TabIndex = 6
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(56, 213)
        Me.txthasil.Multiline = True
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(215, 113)
        Me.txthasil.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Keterangan :", "", "Januari = Payung", "Februari = Laptop", "Maret = Kamera", "April = Sepeda", "Mei = Motor", "Juni =TV", "Juli = Kulkas", "Agustus = AC", "September = Jam Tangan", "Oktober = Baju", "November = Piring", "Desember = Printer"})
        Me.ListBox1.Location = New System.Drawing.Point(291, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 199)
        Me.ListBox1.TabIndex = 8
        '
        'btncek
        '
        Me.btncek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncek.Location = New System.Drawing.Point(87, 167)
        Me.btncek.Name = "btncek"
        Me.btncek.Size = New System.Drawing.Size(89, 40)
        Me.btncek.TabIndex = 9
        Me.btncek.Text = "Cek"
        Me.btncek.UseVisualStyleBackColor = True
        '
        'btnbersihkan
        '
        Me.btnbersihkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbersihkan.Location = New System.Drawing.Point(182, 167)
        Me.btnbersihkan.Name = "btnbersihkan"
        Me.btnbersihkan.Size = New System.Drawing.Size(89, 40)
        Me.btnbersihkan.TabIndex = 10
        Me.btnbersihkan.Text = "Bersihkan"
        Me.btnbersihkan.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(291, 286)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(163, 40)
        Me.btnnext.TabIndex = 11
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 359)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnbersihkan)
        Me.Controls.Add(Me.btncek)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.cbbln)
        Me.Controls.Add(Me.cbtgl)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbtgl As System.Windows.Forms.ComboBox
    Friend WithEvents cbbln As System.Windows.Forms.ComboBox
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btncek As System.Windows.Forms.Button
    Friend WithEvents btnbersihkan As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button

End Class
