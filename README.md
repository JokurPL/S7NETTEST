# Aplikacja Windows Form do sterowania PLC

Aplikacja wykorzystuje bibliotekę ```S7netplus``` w wersji ```0.10.0``` do komunikacji ze sterownikiem.

## Informacja  
Kod odpowiedzialny za kontrole i połączenie znajduje się w pliku ```Form1.cs```

## Używanie programu

Należy pobrać wersję [stabilną programu](https://github.com/JokurPL/S7NETTEST/releases/tag/1.0.0). 
Następnie wypakować i uruchomić plik wykonywalny ```S7NETTEST.exe```.

Program steruje zmiennymi:
- M0.0
- M0.1
- M0.2

## Omówienie programu

```c#

// Funkcja odpowiedzialna za połączenie ze sterownikiem
private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ipLabel.Text)) throw new Exception("Nie podano adresu IP"); // Wyrzucenie wyjątku jeśli nie został podany żadny adres IP
                CpuType plcType = CpuType.S71200; // Przypisanie do zmiennej typu sterownika jako S71200
                string cpuIP = ipLabel.Text; // Przypisanie do zmiennej IP sterownika podane przez sterownik

                plc = new Plc(plcType, cpuIP, 0, 0); // Utworzenie nowego obiektu Plc

                if (!plc.IsConnected) throw new Exception("Nie udało się połączyć z urządzeniem"); // Wyrzucenie wyjątku jeśli połączenie ze sterownikiem nie powiodło się.

                MessageBox.Show(this, "Udało się połączyć z urządzeniem", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); // Poinformowanie o udanym połączeniu ze sterownikiem

                controlPanel.Visible = true;  // Uwidocznienie części kontrolonej programu
 
            } catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // Wyświetlenie komunikatu z wyjątkiem
                if(debug) controlPanel.Visible = true; // Uwidocznienie części kontrolnej programu pod warunkiem, że program jest w trybie testowym
            }
        }
```
```c#
// Handler kliknięcia przycisku (pierwszego - ustawienie M0.0 na 1)
private void onVar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.0", 1); // Ustawienie zmiennej M0.0 sterownika na wartość: 1
                    stateVar1.Text = "Stan: " + (string)plc.Read("M0.0"); // Odczytanie i wyświetlenie wartości zmienej M0.0
                }
                else
                {
                    stateVar1.Text = "Stan: 1"; // Wyświetlenie informacji o kliknięciu jeśli program jest w trybie testowym
                }
            } catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // Wyświetlenie wyjątku
            }
        }
// Handler kliknięcia przycisku (drugiego - ustawienie M0.0 na 0)
private void offVar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.0", 0); // Ustawienie zmiennej M0.0 sterownika na wartość: 0
                    stateVar1.Text = "Stan: " + (string)plc.Read("M0.0"); // Odczytanie i wyświetlenie wartości zmienej M0.0
                }
                else
                {
                    stateVar1.Text = "Stan: 0"; // Wyświetlenie informacji o kliknięciu jeśli program jest w trybie testowym
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // Wyświetlenie wyjątku
            }
        }
// Reszta handlerów różni się tylko adresami.
```
## License
[MIT](https://choosealicense.com/licenses/mit/)
