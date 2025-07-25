Public Class Form2

    Public BG As Image

    Private Sub ClosePictureBox_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SalesGB.Visible = True
        ContainersGB.Visible = False
        CashRemCompGB.Visible = False
        CashBreakGB.Visible = False
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        SalesGB.Visible = True
        ContainersGB.Visible = False
        CashRemCompGB.Visible = False
        CashBreakGB.Visible = False

    End Sub

    Private Sub ConRetBtn_Click(sender As Object, e As EventArgs) Handles ConRetBtn.Click
        SalesGB.Visible = False
        ContainersGB.Visible = True
        CashRemCompGB.Visible = False
        CashBreakGB.Visible = False
    End Sub

    Private Sub CashRemCompBtn_Click(sender As Object, e As EventArgs) Handles CashRemCompBtn.Click
        SalesGB.Visible = False
        ContainersGB.Visible = False
        CashRemCompGB.Visible = True
        CashBreakGB.Visible = False

    End Sub

    Private Sub CashBreakBtn_Click(sender As Object, e As EventArgs) Handles CashBreakBtn.Click
        SalesGB.Visible = False
        ContainersGB.Visible = False
        CashRemCompGB.Visible = False
        CashBreakGB.Visible = True
    End Sub
    'Cali a
    Private Sub CBTxt_TextChanged(sender As Object, e As EventArgs) Handles CBTxt.TextChanged
        CBLbl.Text = CBTxt.Text * 620
    End Sub
    'Cali b
    Private Sub CBbTxt_TextChanged(sender As Object, e As EventArgs) Handles CBbTxt.TextChanged
        CBbLbl.Text = CBbTxt.Text * 27.33
    End Sub
    'Cali Can
    Private Sub CCTxt_TextChanged(sender As Object, e As EventArgs) Handles CCTxt.TextChanged
        CcLbl.Text = CCTxt.Text * 650
    End Sub
    'Magnolia Healthy a
    Private Sub HTTxt_TextChanged(sender As Object, e As EventArgs) Handles HTTxt.TextChanged
        HTLbl.Text = HTTxt.Text * 307
    End Sub
    'Magnolia Healthy b
    Private Sub HTbTxt_TextChanged(sender As Object, e As EventArgs) Handles HTbTxt.TextChanged
        HtbLbl.Text = HTbTxt.Text * 11
    End Sub
    'Pam a
    Private Sub PAMBTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMBTxt.TextChanged
        PAMBLbl.Text = PAMBTxt.Text * 1567
    End Sub
    'Pam b
    Private Sub PAMBbTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMBbTxt.TextChanged
        PAMBbLbl.Text = PAMBbTxt.Text * 61.79
    End Sub
    'Pam c
    Private Sub PAMCTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMCTxt.TextChanged
        PAMCLbl.Text = PAMCTxt.Text * 1582
    End Sub
    'Kirin a
    Private Sub KRBTxt_TextChanged(sender As Object, e As EventArgs) Handles KRBTxt.TextChanged
        KRBLbl.Text = KRBTxt.Text * 1728
    End Sub
    'Kirin b
    Private Sub KRBbTxt_TextChanged(sender As Object, e As EventArgs) Handles KRBbTxt.TextChanged
        KRBbLbl.Text = KRBbTxt.Text * 73.5
    End Sub

    Private Sub KRCTxt_TextChanged(sender As Object, e As EventArgs) Handles KRCTxt.TextChanged
        KRCLbl.Text = KRCTxt.Text * 1770
    End Sub

    Private Sub SMZBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMZBTxt.TextChanged
        SMZBLbl.Text = SMZBTxt.Text * 1052
    End Sub

    Private Sub SMZBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMZBbTxt.TextChanged
        SMZBbLbl.Text = SMZBbTxt.Text * 45.33
    End Sub

    Private Sub SMLBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLBTxt.TextChanged
        SMLBLbl.Text = SMLBTxt.Text * 1005
    End Sub

    Private Sub SMLBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLBbTxt.TextChanged
        SMLBbLbl.Text = SMLBbTxt.Text * 43.375
    End Sub

    Private Sub SMLCTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLCTxt.TextChanged
        SMLCLbl.Text = SMLCTxt.Text * 1175
    End Sub

    Private Sub FBTxt_TextChanged(sender As Object, e As EventArgs) Handles FBTxt.TextChanged
        FBLbl.Text = FBTxt.Text * 952
    End Sub

    Private Sub FBbTxt_TextChanged(sender As Object, e As EventArgs) Handles FBbTxt.TextChanged
        FBbLbl.Text = FBbTxt.Text * 36.16
    End Sub

    Private Sub FBACTxt_TextChanged(sender As Object, e As EventArgs) Handles FBACTxt.TextChanged
        FBACLbl.Text = FBACTxt.Text * 1102
    End Sub

    Private Sub PPTxt_TextChanged(sender As Object, e As EventArgs) Handles PPTxt.TextChanged
        PPLbl.Text = PPTxt.Text * 972
    End Sub

    Private Sub PPbTxt_TextChanged(sender As Object, e As EventArgs) Handles PPbTxt.TextChanged
        PPbLbl.Text = PPbTxt.Text * 37
    End Sub

    Private Sub PPGTxt_TextChanged(sender As Object, e As EventArgs) Handles PPGTxt.TextChanged
        PPGLbl.Text = PPGTxt.Text * 1140
    End Sub

    Private Sub PPGbTxt_TextChanged(sender As Object, e As EventArgs) Handles PPGbTxt.TextChanged
        PPGBbLbl.Text = PPGbTxt.Text * 44
    End Sub

    Private Sub PLTxt_TextChanged(sender As Object, e As EventArgs) Handles PLTxt.TextChanged
        PLLbl.Text = PLTxt.Text * 707
    End Sub

    Private Sub PLbTxt_TextChanged(sender As Object, e As EventArgs) Handles PLbTxt.TextChanged
        PLbLbl.Text = PLbTxt.Text * 135.83
    End Sub

    Private Sub RHSTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSTxt.TextChanged
        RHSLbl.Text = RHSTxt.Text * 1033
    End Sub

    Private Sub RHSbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSbTxt.TextChanged
        RHSbLbl.Text = RHSbTxt.Text * 39.54
    End Sub

    Private Sub RHPTxt_TextChanged(sender As Object, e As EventArgs) Handles RHPTxt.TextChanged
        RHPLbl.Text = RHPTxt.Text * 725
    End Sub

    Private Sub RHPbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHPbTxt.TextChanged
        RHPbLbl.Text = RHPbTxt.Text * 55.66
    End Sub

    Private Sub RHLTxt_TextChanged(sender As Object, e As EventArgs) Handles RHLTxt.TextChanged
        RHLLbl.Text = RHLTxt.Text * 737
    End Sub

    Private Sub RHLbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHLbTxt.TextChanged
        RHLbLbl.Text = RHLbTxt.Text * 108.83
    End Sub

    Private Sub RH500CTxt_TextChanged(sender As Object, e As EventArgs) Handles RH500CTxt.TextChanged
        RH500CLbl.Text = RH500CTxt.Text * 1667
    End Sub

    Private Sub RHSLTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSLTxt.TextChanged
        RHSLLbl.Text = RHSLTxt.Text * 785
    End Sub

    Private Sub RHSLbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSLbTxt.TextChanged
        RHSLbLbl.Text = RHSLbTxt.Text * 116.83
    End Sub

    Private Sub SMFBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFBTxt.TextChanged
        SMFBLbl.Text = SMFBTxt.Text * 894
    End Sub

    Private Sub SMFBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFBbTxt.TextChanged
        SMFBbLbl.Text = SMFBbTxt.Text * 36.958
    End Sub

    Private Sub SMFCTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFCTxt.TextChanged
        SMFCLbl.Text = SMFCTxt.Text * 1102
    End Sub

    Private Sub GE320Txt_TextChanged(sender As Object, e As EventArgs) Handles GE320Txt.TextChanged
        GE320Lbl.Text = GE320Txt.Text * 823
    End Sub

    Private Sub GE320bTxt_TextChanged(sender As Object, e As EventArgs) Handles GE320bTxt.TextChanged
        GE320bLbl.Text = GE320bTxt.Text * 30.791
    End Sub

    Private Sub GEKTxt_TextChanged(sender As Object, e As EventArgs) Handles GEKTxt.TextChanged
        GEKLbl.Text = GEKTxt.Text * 670
    End Sub

    Private Sub GEKbTxt_TextChanged(sender As Object, e As EventArgs) Handles GEKbTxt.TextChanged
        GEKbLbl.Text = GEKbTxt.Text * 97.66
    End Sub

    Private Sub HSCTxt_TextChanged(sender As Object, e As EventArgs) Handles HSCTxt.TextChanged
        HSCLbl.Text = HSCTxt.Text * 1142
    End Sub
    'Total Sales
    Private Sub TotalSalesLbl2_Click(sender As Object, e As EventArgs) Handles TotalSalesLbl2.Click
        TotalSalesLbl2.Text = Val(CBLbl.Text) + Val(CBbLbl.Text) + Val(CcLbl.Text) + Val(HTLbl.Text) + Val(HtbLbl.Text) +
            Val(PAMBLbl.Text) + Val(PAMBbLbl.Text) + Val(PAMCLbl.Text) + Val(KRBLbl.Text) + Val(KRBbLbl.Text) + Val(KRCLbl.Text) + Val(SMZBLbl.Text) +
            Val(SMZBbLbl.Text) + Val(SMLBLbl.Text) + Val(SMLBbLbl.Text) + Val(SMLCLbl.Text) + Val(FBLbl.Text) + Val(FBbLbl.Text) + Val(FBACLbl.Text) + Val(PPLbl.Text) +
            Val(PPbLbl.Text) + Val(PPGLbl.Text) + Val(PPGBbLbl.Text) + Val(PLLbl.Text) + Val(PLbLbl.Text) + Val(RHSLbl.Text) + Val(RHSbLbl.Text) + Val(RHPLbl.Text) +
            Val(RHPbLbl.Text) + Val(RHLLbl.Text) + Val(RHLbLbl.Text) + Val(RH500CLbl.Text) + Val(RHSLLbl.Text) + Val(RHSLbLbl.Text) + Val(SMFBLbl.Text) +
            Val(SMFBbLbl.Text) + Val(SMFCLbl.Text) + Val(GE320Lbl.Text) + Val(GE320bLbl.Text) + Val(GEKLbl.Text) + Val(GEKbLbl.Text) + Val(HSCLbl.Text)

        If TotalSalesLbl2.Text = 00.00 Then
            TotalSalesLbl2.Text = "Click to see the total"
            MsgBox("Empty fields", vbInformation)
        End If

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        If CBTxt.Text = Val(CBbLbl.Text) Then
            CBTxt.Text = " "
            CBLbl.Text = 00.00
            TotalSalesLbl2.Text = "Click to see the total"
        End If
        'If TotalSalesLbl2.Text = "Click to see the total" Then
        'CBLbl.Text = "00.00"
        'CBbTxt.Text = " "
        'End If
    End Sub

    Private Sub PrintDocBtn_Click(sender As Object, e As EventArgs) Handles PrintDocBtn.Click

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(GBDSFormatDoc.Image, 0, 0)
    End Sub
End Class