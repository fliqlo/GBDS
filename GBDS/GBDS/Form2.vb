Public Class Form2
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
        Dim Cali_Price = 500 + 120
        CBLbl.Text = CBTxt.Text * Cali_Price
        'TotalSalesLbl2.Text = CBLbl.Text
    End Sub
    'Cali b
    Private Sub CBbTxt_TextChanged(sender As Object, e As EventArgs) Handles CBbTxt.TextChanged
        Dim Calib_Price = 620 / 24 + 1.5
        CBbLbl.Text = CBbTxt.Text * Calib_Price
        'TotalSalesLbl2.Text = CBbLbl.Text
    End Sub
    'Cali Can
    Private Sub CCTxt_TextChanged(sender As Object, e As EventArgs) Handles CCTxt.TextChanged
        Dim CC_Price = 650
        CcLbl.Text = CCTxt.Text * CC_Price
    End Sub
    'Magnolia Healthy a
    Private Sub HTTxt_TextChanged(sender As Object, e As EventArgs) Handles HTTxt.TextChanged
        Dim HT_Price = 307
        HTLbl.Text = HTTxt.Text * HT_Price
    End Sub
    'Magnolia Healthy b
    Private Sub HTbTxt_TextChanged(sender As Object, e As EventArgs) Handles HTbTxt.TextChanged
        Dim HTb_Price = 11
        HtbLbl.Text = HTbTxt.Text * HTb_Price
    End Sub
    'Pam a
    Private Sub PAMBTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMBTxt.TextChanged
        Dim PAMB_Price = 1567
        PAMBLbl.Text = PAMBTxt.Text * PAMB_Price
    End Sub
    'Pam b
    Private Sub PAMBbTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMBbTxt.TextChanged
        Dim PAMBb_Price = 1447 / 24 + 1.5
        PAMBbLbl.Text = PAMBbTxt.Text * PAMBb_Price
    End Sub
    'Pam c
    Private Sub PAMCTxt_TextChanged(sender As Object, e As EventArgs) Handles PAMCTxt.TextChanged
        Dim PAMC_Price = 1582
        PAMCLbl.Text = PAMCTxt.Text * PAMC_Price
    End Sub
    'Kirin a
    Private Sub KRBTxt_TextChanged(sender As Object, e As EventArgs) Handles KRBTxt.TextChanged
        KRBLbl.Text = KRBTxt.Text * 1728
    End Sub
    'Kirin b
    Private Sub KRBbTxt_TextChanged(sender As Object, e As EventArgs) Handles KRBbTxt.TextChanged
        KRBbLbl.Text = KRBbTxt.Text * 1728 / 24 + 1.5
    End Sub

    Private Sub KRCTxt_TextChanged(sender As Object, e As EventArgs) Handles KRCTxt.TextChanged
        KRCLbl.Text = KRCTxt.Text * 1770
    End Sub

    Private Sub SMZBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMZBTxt.TextChanged
        SMZBLbl.Text = SMZBTxt.Text * 1052
    End Sub

    Private Sub SMZBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMZBbTxt.TextChanged
        SMZBbLbl.Text = SMZBbTxt.Text * 1052 / 24 + 1.5
    End Sub

    Private Sub SMLBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLBTxt.TextChanged
        SMLBLbl.Text = SMLBTxt.Text * 1005
    End Sub

    Private Sub SMLBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLBbTxt.TextChanged
        SMLBbLbl.Text = SMLBbTxt.Text * 1005 / 24 + 1.5
    End Sub

    Private Sub SMLCTxt_TextChanged(sender As Object, e As EventArgs) Handles SMLCTxt.TextChanged
        SMLCLbl.Text = SMLCTxt.Text * 1175
    End Sub

    Private Sub FBTxt_TextChanged(sender As Object, e As EventArgs) Handles FBTxt.TextChanged
        FBLbl.Text = FBTxt.Text * 952
    End Sub

    Private Sub FBbTxt_TextChanged(sender As Object, e As EventArgs) Handles FBbTxt.TextChanged
        FBbLbl.Text = FBbTxt.Text * 832 / 24 + 1.5
    End Sub

    Private Sub FBACTxt_TextChanged(sender As Object, e As EventArgs) Handles FBACTxt.TextChanged
        FBACLbl.Text = FBACTxt.Text * 1102
    End Sub

    Private Sub PPTxt_TextChanged(sender As Object, e As EventArgs) Handles PPTxt.TextChanged
        PPLbl.Text = PPTxt.Text * 972
    End Sub

    Private Sub PPbTxt_TextChanged(sender As Object, e As EventArgs) Handles PPbTxt.TextChanged
        PPbLbl.Text = PPbTxt.Text * 852 / 24 + 1.5
    End Sub

    Private Sub PPGTxt_TextChanged(sender As Object, e As EventArgs) Handles PPGTxt.TextChanged
        PPGLbl.Text = PPGTxt.Text * 1140
    End Sub

    Private Sub PPGbTxt_TextChanged(sender As Object, e As EventArgs) Handles PPGbTxt.TextChanged
        PPGBbLbl.Text = PPGbTxt.Text * 1020 / 24 + 1.5
    End Sub

    Private Sub PLTxt_TextChanged(sender As Object, e As EventArgs) Handles PLTxt.TextChanged
        PLLbl.Text = PLTxt.Text * 707
    End Sub

    Private Sub PLbTxt_TextChanged(sender As Object, e As EventArgs) Handles PLbTxt.TextChanged
        PLbLbl.Text = PLbTxt.Text * 596 / 24 + 111
    End Sub

    Private Sub RHSTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSTxt.TextChanged
        RHSLbl.Text = RHSTxt.Text * 1033
    End Sub

    Private Sub RHSbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSbTxt.TextChanged
        RHSbLbl.Text = RHSbTxt.Text * 913 / 24 + 1.5
    End Sub

    Private Sub RHPTxt_TextChanged(sender As Object, e As EventArgs) Handles RHPTxt.TextChanged
        RHPLbl.Text = RHPTxt.Text * 725
    End Sub

    Private Sub RHPbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHPbTxt.TextChanged
        RHPbLbl.Text = RHPbTxt.Text * 614 / 12 + 4.5
    End Sub

    Private Sub RHLTxt_TextChanged(sender As Object, e As EventArgs) Handles RHLTxt.TextChanged
        RHLLbl.Text = RHLTxt.Text * 737
    End Sub

    Private Sub RHLbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHLbTxt.TextChanged
        RHLbLbl.Text = RHLbTxt.Text * 626 / 6 + 4.5
    End Sub

    Private Sub RH500CTxt_TextChanged(sender As Object, e As EventArgs) Handles RH500CTxt.TextChanged
        RH500CLbl.Text = RH500CTxt.Text * 1667
    End Sub

    Private Sub RHSLTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSLTxt.TextChanged
        RHSLLbl.Text = RHSLTxt.Text * 785
    End Sub

    Private Sub RHSLbTxt_TextChanged(sender As Object, e As EventArgs) Handles RHSLbTxt.TextChanged
        RHSLbLbl.Text = RHSLbTxt.Text * 674 / 6 + 4.5
    End Sub

    Private Sub SMFBTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFBTxt.TextChanged
        SMFBLbl.Text = SMFBTxt.Text * 894
    End Sub

    Private Sub SMFBbTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFBbTxt.TextChanged
        SMFBbLbl.Text = SMFBbTxt.Text * 851 / 24 + 1.5
    End Sub

    Private Sub SMFCTxt_TextChanged(sender As Object, e As EventArgs) Handles SMFCTxt.TextChanged
        SMFCLbl.Text = SMFCTxt.Text * 1102
    End Sub

    Private Sub GE320Txt_TextChanged(sender As Object, e As EventArgs) Handles GE320Txt.TextChanged
        GE320Lbl.Text = GE320Txt.Text * 823
    End Sub

    Private Sub GE320bTxt_TextChanged(sender As Object, e As EventArgs) Handles GE320bTxt.TextChanged
        GE320bLbl.Text = GE320bTxt.Text * 703 / 24 + 1.5
    End Sub

    Private Sub GEKTxt_TextChanged(sender As Object, e As EventArgs) Handles GEKTxt.TextChanged
        GEKLbl.Text = GEKTxt.Text * 670
    End Sub

    Private Sub GEKbTxt_TextChanged(sender As Object, e As EventArgs) Handles GEKbTxt.TextChanged
        GEKbLbl.Text = GEKbTxt.Text * 559 / 6 + 4.5
    End Sub

    Private Sub HSCTxt_TextChanged(sender As Object, e As EventArgs) Handles HSCTxt.TextChanged
        HSCLbl.Text = HSCTxt.Text * 1142
    End Sub

    Private Sub TotalSalesLbl2_Click(sender As Object, e As EventArgs) Handles TotalSalesLbl2.Click

        TotalSalesLbl2.Text = Val(CBLbl.Text) + Val(CBbLbl.Text)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click

    End Sub
End Class