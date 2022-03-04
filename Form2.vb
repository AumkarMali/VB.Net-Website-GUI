
Public Class frmCustomize

    'Globalize: total cost var, Pizza Size, Order type, Payment method
    Dim Total_Cost_Val As Decimal = 0
    Dim Total_Cost_Tax As Decimal = 0
    Dim Pizza_Size As String
    Dim Order_Type As String
    Dim Payment_Method As String

    'Define cost of toppings
    Dim Ham_val As Decimal = 2.34
    Dim Pepperoni_val As Decimal = 1.77
    Dim Mushrooms_val As Decimal = 1.03
    Dim Chicken_val As Decimal = 1.45
    Dim Sausage_val As Decimal = 2.13
    Dim Bacon_val As Decimal = 2.32
    Dim Onion_val As Decimal = 0.56
    Dim Tomatoe_val As Decimal = 0.78

    'Define cost of side items
    Dim Soda_val As Decimal = 4.5
    Dim Fries_val As Decimal = 3.56
    Dim Wings_val As Decimal = 9.46
    Dim GarlicBread_val As Decimal = 5.98

    Dim Small_Pizza_Val As Integer = 10
    Dim Medium_Pizza_Val As Integer = 13
    Dim Large_Pizza_Val As Integer = 14
    Dim Xlarge_Pizza_Val As Integer = 18

    'Boolean statements for signaling functions when each has been clicked
    Dim Ham_Checked As Boolean = False
    Dim Pepperoni_Checked As Boolean = False
    Dim Mushrooms_Checked As Boolean = False
    Dim Chicken_Checked As Boolean = False
    Dim Sausage_Checked As Boolean = False
    Dim Bacon_Checked As Boolean = False
    Dim Onion_Checked As Boolean = False
    Dim Tomatoe_Checked As Boolean = False

    Dim Soda_Checked As Boolean = False
    Dim Fries_Checked As Boolean = False
    Dim Wings_Checked As Boolean = False
    Dim Garlic_Bread_Checked As Boolean = False

    'These variables represent the sub total of a category 
    Dim Topping_Total_Val As Decimal
    Dim Side_Item_Total_Val As Decimal

    'This var is the first char of the pizza size (This is because it needs to fit inside the groupbox text
    Dim Pizza_Size_Abbreviation As Char

    Dim GroupBoxTitleFont As New System.Drawing.Font("times new roman", 12)
    Dim TotalButtonFont As New System.Drawing.Font("sans serif", 12)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtConfirm.Hide()
        btnProceedCheckout.Hide()
        btnSaveReceipt.Hide()
        btnPrintReceipt.Hide()

        'Style code for 'total' button
        btnTotal.FlatStyle = FlatStyle.Flat
        btnTotal.ForeColor = System.Drawing.Color.Black
        btnTotal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        btnTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0)
        btnTotal.Font = TotalButtonFont

        'Loading groupbox data: Transparency in groupbox(s), Title font
        grbSize.BackColor = Color.FromArgb(100, 0, 0, 0)
        grbSize.Font = GroupBoxTitleFont

        grbToppings.BackColor = Color.FromArgb(100, 0, 0, 0)
        grbToppings.Font = GroupBoxTitleFont

        grbSideItems.BackColor = Color.FromArgb(100, 0, 0, 0)
        grbSideItems.Font = GroupBoxTitleFont

        lblCouponInfo.TextAlign = ContentAlignment.MiddleCenter
    End Sub



    Private Sub txtCouponCode_TextChanged(sender As Object, e As EventArgs) Handles txtCouponCode.TextChanged
        'Converts letters inputted to upper case http://www.databasedev.co.uk/convert_text.html
        txtCouponCode.Text = StrConv(txtCouponCode.Text, vbUpperCase)
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        'Checks coupon code
        If txtCouponCode.Text = "HDCVGF" Then 'Coupon code, all sides free
            Soda_val = 0
            Fries_val = 0
            Wings_val = 0
            GarlicBread_val = 0
        End If



        'Pizza size cost
        If rabSmall.Checked = True Then
            Pizza_Size = "small"
            Total_Cost_Val += Small_Pizza_Val
        ElseIf rabMedium.Checked = True Then
            Pizza_Size = "medium"
            Total_Cost_Val += Medium_Pizza_Val
        ElseIf rabLarge.Checked = True Then
            Pizza_Size = "large"
            Total_Cost_Val += Large_Pizza_Val
        ElseIf rabXLarge.Checked = True Then
            Pizza_Size = "x-large"
            Total_Cost_Val += Xlarge_Pizza_Val
        End If

        'Cost of Toppings
        If chkHam.Checked Then
            Total_Cost_Val += Ham_val
            Ham_Checked = True

            Topping_Total_Val += Ham_val
        End If
        If chkPepperoni.Checked Then
            Total_Cost_Val += Pepperoni_val
            Pepperoni_Checked = True

            Topping_Total_Val += Pepperoni_val
        End If
        If chkMushrooms.Checked Then
            Total_Cost_Val += Mushrooms_val
            Mushrooms_Checked = True

            Topping_Total_Val += Mushrooms_val
        End If
        If chkChicken.Checked Then
            Total_Cost_Val += Chicken_val
            Chicken_Checked = True

            Topping_Total_Val += Chicken_val
        End If
        If chkSausage.Checked Then
            Total_Cost_Val += Sausage_val
            Sausage_Checked = True

            Topping_Total_Val += Sausage_val
        End If
        If chkBacon.Checked Then
            Total_Cost_Val += Bacon_val
            Bacon_Checked = True

            Topping_Total_Val += Bacon_val
        End If
        If chkOnion.Checked Then
            Total_Cost_Val += Onion_val
            Onion_Checked = True

            Topping_Total_Val += Onion_val
        End If
        If chkTomatoe.Checked Then
            Total_Cost_Val += Tomatoe_val
            Tomatoe_Checked = True

            Topping_Total_Val += Tomatoe_val
        End If

        'Cost of Side Items
        If chkSoda.Checked = True Then
            Total_Cost_Val += Soda_val
            Soda_Checked = True

            Side_Item_Total_Val += Soda_val
        End If
        If chkFries.Checked = True Then
            Total_Cost_Val += Fries_val
            Fries_Checked = True

            Side_Item_Total_Val += Fries_val
        End If
        If chkWings.Checked = True Then
            Total_Cost_Val += Wings_val
            Wings_Checked = True

            Side_Item_Total_Val += Wings_val
        End If
        If chkGarlicBread.Checked = True Then
            Total_Cost_Val += GarlicBread_val
            Garlic_Bread_Checked = True

            Side_Item_Total_Val += GarlicBread_val
        End If

        'Get order type
        If rabDelivery.Checked = True Then
            Order_Type = "Delivery"
        ElseIf rabPickUp.Checked = True Then
            Order_Type = "Pick-up"
        End If

        'Payment type
        If rabCash.Checked = True Then
            Payment_Method = "Cash"
        ElseIf rabCredit.Checked = True Then
            Payment_Method = "Credit"
        ElseIf rabDebit.Checked = True Then
            Payment_Method = "Debit"
        End If

        grbToppings.Text = "Toppings: $" + Str(Topping_Total_Val)
        grbSideItems.Text = "Side Items: $" + Str(Side_Item_Total_Val)

        'Changes str into first letter capital to represent the size (Ex: Small is represented as "S")
        Pizza_Size_Abbreviation = Pizza_Size.Substring(0, 1)
        Pizza_Size_Abbreviation = StrConv(Pizza_Size_Abbreviation, vbUpperCase)

        grbSize.Text = "Pizza Size: " + Pizza_Size_Abbreviation

        txtConfirm.Show()
        btnProceedCheckout.Show()

        txtConfirm.Text = "Confirm"

        Total_Cost_Tax = Total_Cost_Val + (Total_Cost_Val * 0.13) 'Adding tax, 13% HST

        Total_Cost_Tax = Math.Round(Total_Cost_Tax, 2)

        txtCouponCode.Text = Nothing

        Topping_Total_Val = 0
        Side_Item_Total_Val = 0

    End Sub


    'Hides textbox cursor https://stackoverflow.com/questions/41113506/disable-ibeam-pointer-in-textbox-using-vb-net
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean

    Private Sub txtReceipt_GotFocus(sender As Object, e As EventArgs) Handles txtReceipt.GotFocus
        HideCaret(txtReceipt.Handle)
    End Sub


    Private Sub btnBackPage_Click(sender As Object, e As EventArgs) Handles btnBackPage.Click
        Dim myForm As New frmIntroScreen
        'show Information form on button click
        myForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function

        Dim ExitMsg, Style, Title, Response
        ExitMsg = "Do you want to Exit?"
        Style = vbYesNo
        Title = "Exit"

        Response = MsgBox(ExitMsg, Style, Title)
        If Response = vbYes Then
            Application.Exit()
        End If

    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click


        'Clear all textboxes https://scriptjunkiesourav.wordpress.com/2015/06/01/clear-all-textbox-and-uncheck-all-checkbox-in-vb-net/
        For Each textclear As Control In Me.Controls
            If TypeOf textclear Is TextBox Then
                textclear.Text = Nothing
            End If

        Next

        'Uncheck all checkboxes
        chkHam.CheckState = CheckState.Unchecked
        chkPepperoni.CheckState = CheckState.Unchecked
        chkMushrooms.CheckState = CheckState.Unchecked
        chkChicken.CheckState = CheckState.Unchecked
        chkSausage.CheckState = CheckState.Unchecked
        chkBacon.CheckState = CheckState.Unchecked
        chkOnion.CheckState = CheckState.Unchecked
        chkTomatoe.CheckState = CheckState.Unchecked

        chkSoda.CheckState = CheckState.Unchecked
        chkFries.CheckState = CheckState.Unchecked
        chkWings.CheckState = CheckState.Unchecked

        'Uncheck radioboxes
        rabSmall.Checked = False
        rabMedium.Checked = False
        rabLarge.Checked = False
        rabXLarge.Checked = False

        rabDelivery.Checked = False
        rabPickUp.Checked = False

        rabCash.Checked = False
        rabCredit.Checked = False
        rabDebit.Checked = False

        btnPrintReceipt.Hide()
        btnSaveReceipt.Hide()

    End Sub


    Private Sub btnProceedCheckout_Click(sender As Object, e As EventArgs) Handles btnProceedCheckout.Click

        'Resets textbox 
        txtReceipt.Text = Nothing

        txtReceipt.TextAlign = HorizontalAlignment.Center

        txtReceipt.AppendText("Little Caesers" + vbNewLine)
        txtReceipt.AppendText("The Highest quality of Pizza" + vbNewLine)
        txtReceipt.AppendText("Hot'n Fresh!" + vbNewLine)
        txtReceipt.AppendText("(905) 565-6050" + vbNewLine)


        txtReceipt.AppendText(vbNewLine + "Pizza Size" + vbTab + vbTab + vbTab + vbTab + vbNewLine)

        If Pizza_Size = "small" Then
            txtReceipt.AppendText("Small" + vbTab + vbTab + vbTab + "$" + Str(Small_Pizza_Val) + vbNewLine)
        Else
            txtReceipt.AppendText("Small" + vbTab + vbTab + vbTab + vbTab + vbNewLine)
        End If

        If Pizza_Size = "medium" Then
            txtReceipt.AppendText("Medium" + vbTab + vbTab + vbTab + "$" + Str(Medium_Pizza_Val) + vbNewLine)
        Else
            txtReceipt.AppendText("Medium" + vbTab + vbTab + vbTab + vbTab + vbNewLine)
        End If

        If Pizza_Size = "large" Then
            txtReceipt.AppendText("Large" + vbTab + vbTab + vbTab + "$" + Str(Large_Pizza_Val) + vbNewLine)
        Else
            txtReceipt.AppendText("Large" + vbTab + vbTab + vbTab + vbTab + vbNewLine)
        End If

        If Pizza_Size = "x-large" Then
            txtReceipt.AppendText("X-Large" + vbTab + vbTab + vbTab + "$" + Str(Xlarge_Pizza_Val) + vbNewLine)
        Else
            txtReceipt.AppendText("X-Large" + vbTab + vbTab + vbTab + vbTab + vbNewLine)
        End If


        txtReceipt.AppendText(vbNewLine + "Toppings" + vbTab + vbTab + vbTab + vbTab + vbNewLine)

        If Ham_Checked Then
            txtReceipt.AppendText(vbNewLine + "Ham" + vbTab + vbTab + vbTab + "$" + Str(Ham_val)) 'Spacing is added to clean up receipt arrangement
        End If

        If Pepperoni_Checked Then
            txtReceipt.AppendText(vbNewLine + "Pepperoni" + vbTab + vbTab + "$" + Str(Pepperoni_val))
        End If

        If Mushrooms_Checked Then
            txtReceipt.AppendText(vbNewLine + "Mushrooms" + vbTab + vbTab + "$" + Str(Mushrooms_val))
        End If

        If Chicken_Checked Then
            txtReceipt.AppendText(vbNewLine + "Chicken" + vbTab + vbTab + vbTab + "$" + Str(Chicken_val))
        End If

        If Sausage_Checked Then
            txtReceipt.AppendText(vbNewLine + "Sausage" + vbTab + vbTab + vbTab + "$" + Str(Sausage_val))
        End If

        If Bacon_Checked Then
            txtReceipt.AppendText(vbNewLine + "Bacon" + vbTab + vbTab + vbTab + "$" + Str(Bacon_val))
        End If

        If Onion_Checked Then
            txtReceipt.AppendText(vbNewLine + "Onion" + vbTab + vbTab + vbTab + "$" + Str(Onion_val))
        End If

        If Tomatoe_Checked Then
            txtReceipt.AppendText(vbNewLine + "Tomatoe" + vbTab + vbTab + vbTab + "$" + Str(Tomatoe_val))
        End If


        txtReceipt.AppendText(vbNewLine + vbNewLine + "Side Items" + vbTab + vbTab + vbTab + vbTab + vbNewLine)

        If Soda_Checked Then
            txtReceipt.AppendText(vbNewLine + "Soda" + vbTab + vbTab + vbTab + "$" + Str(Soda_val))
        End If

        If Fries_Checked Then
            txtReceipt.AppendText(vbNewLine + "Fries" + vbTab + vbTab + vbTab + "$" + Str(Fries_val))
        End If

        If Wings_Checked Then
            txtReceipt.AppendText(vbNewLine + "Wings" + vbTab + vbTab + vbTab + "$" + Str(Wings_val))
        End If

        If Garlic_Bread_Checked Then
            txtReceipt.AppendText(vbNewLine + "Garlic Bread" + vbTab + vbTab + "$" + Str(GarlicBread_val))
        End If


        txtReceipt.AppendText(vbNewLine + vbNewLine + "Order Type: " + Order_Type + vbTab + vbTab)
        txtReceipt.AppendText(vbNewLine + vbNewLine + "   Payment Method: " + Payment_Method + vbTab + vbTab)

        txtReceipt.AppendText(vbNewLine + vbNewLine + "Sub total: $" + Str(Total_Cost_Val) + vbTab + vbTab)
        txtReceipt.AppendText(vbNewLine + vbNewLine + "Tax (HST): $" + Str(Total_Cost_Tax - Total_Cost_Val) + vbTab + vbTab)
        txtReceipt.AppendText(vbNewLine + vbNewLine + "Total: $" + Str(Total_Cost_Tax) + vbTab + vbTab)

        txtReceipt.AppendText(vbNewLine + vbNewLine + "Thank You!")
        txtReceipt.AppendText(vbNewLine + "Have a nice day!")

        'Hide checkout buttons
        txtConfirm.Hide()
        btnProceedCheckout.Hide()

        btnSaveReceipt.Show()
        btnPrintReceipt.Show()

        Total_Cost_Val = 0
        Total_Cost_Tax = 0

    End Sub

    Private Sub btnSaveReceipt_Click(sender As Object, e As EventArgs) Handles btnSaveReceipt.Click

        Try
            'This resets the receipt and prevents overwriting
            My.Computer.FileSystem.DeleteFile("Receipt.txt")
        Catch ex As Exception

        End Try

        'Saves receipt
        My.Computer.FileSystem.WriteAllText("Receipt.txt", txtReceipt.Text, True)

        MessageBox.Show("Receipt has been saved...")

    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click

        'Prints document; text inside textbox
        PrintDocument.DocumentName = txtReceipt.Text

        PrintDialog1.Document = PrintDocument
        PrintDialog1.PrinterSettings = PrintDocument.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument.Print()
        End If

    End Sub

End Class