# In_Out_Application
Přihlášení zaměstnance pomocí loginu k danému času, následný výpočet času po odchodu. Plná administrace, možné změny chybných příchodů/odchodů a další. 

Aplikaci bych nazval trochu chaotickou (málo funkcí, hodně kódu na jednou, takže špatná zpětná úprava kódu) -
tomuto problému jsem se snažil předejít u druhého projektu (Hotel_Application)

Form1 - první form, který se zobrazí. Z něj se můžeme dostat na Příchod/Odchod nebo Admin form.

Form_in - form pro vložení loginu, následně zapíše příchod

Form_out - form pro vložení loginu, následně zapíše odchod

Form_admin_login - form pro vložení loginu a hesla admina

Admin_logged_main - form pro admin rozhraní - tvorba nového člena, práce s hodnostmi, změna hesla, mazání členů, úprava času

Form_changeINOUT - form, kde vyberu člena a následně mohu upravit čas příchodů/odchodů
