# Cheat sheet C# WinForms: form, MDI e date

## Mappa rapida

| Tipo di apertura | Codice | Comportamento |
|---|---|---|
| Finestra separata | `form.Show()` | Non blocca la form precedente |
| Finestra separata con proprietario | `form.Show(this)` | Collega la finestra al suo `Owner` |
| Finestra modale | `form.ShowDialog(this)` | Blocca il proprietario finché non viene chiusa |
| Form dentro un contenitore MDI | `form.MdiParent = this; form.Show();` | Rimane dentro la form principale |
| Form dentro un `Panel` | `TopLevel = false` e `panel.Controls.Add(form)` | Utile per dashboard e navigazione interna |

## Form MDI

### Creare il contenitore

Dal Designer imposta:

```text
IsMdiContainer = true
WindowState = Maximized
```

Oppure dal costruttore:

```csharp
public FormPrincipale()
{
    InitializeComponent();

    IsMdiContainer = true;
    WindowState = FormWindowState.Maximized;
}
```

### Aprire una form dentro il contenitore

```csharp
private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
{
    FormClienti formClienti = new FormClienti();

    formClienti.MdiParent = this;
    formClienti.Show();
}
```

`MdiParent` deve essere una form con `IsMdiContainer = true`.

### Evitare di aprire due volte la stessa form

Serve `using System.Linq;`.

```csharp
private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
{
    FormClienti formAperta = MdiChildren
        .OfType<FormClienti>()
        .FirstOrDefault();

    if (formAperta == null)
    {
        FormClienti formClienti = new FormClienti();
        formClienti.MdiParent = this;
        formClienti.Show();
    }
    else
    {
        formAperta.WindowState = FormWindowState.Normal;
        formAperta.Activate();
        formAperta.BringToFront();
    }
}
```

### Gestire le form MDI aperte

```csharp
// Form attiva
Form formAttiva = ActiveMdiChild;

// Chiude la form attiva, se esiste
ActiveMdiChild?.Close();

// Numero di form figlie aperte
int numeroForm = MdiChildren.Length;

// Chiude tutte le form figlie
foreach (Form form in MdiChildren)
{
    form.Close();
}
```

### Disporre le finestre

```csharp
LayoutMdi(MdiLayout.Cascade);
LayoutMdi(MdiLayout.TileHorizontal);
LayoutMdi(MdiLayout.TileVertical);
LayoutMdi(MdiLayout.ArrangeIcons);
```

### Elenco automatico delle finestre nel menu

```csharp
menuStrip1.MdiWindowListItem = finestreToolStripMenuItem;
```

Windows aggiunge automaticamente nel menu l'elenco delle form MDI aperte.

## Form separate e modali

### Apertura normale

```csharp
FormClienti formClienti = new FormClienti();
formClienti.Show();
```

### Apertura con proprietario

```csharp
FormClienti formClienti = new FormClienti();
formClienti.Show(this);
```

Nella seconda form puoi recuperare il proprietario:

```csharp
FormPrincipale principale = (FormPrincipale)Owner;
```

`Owner` e `MdiParent` sono diversi:

- `Owner`: le finestre rimangono separate ma collegate;
- `MdiParent`: la form figlia è contenuta graficamente nella form principale.

### Apertura modale

```csharp
FormLogin formLogin = new FormLogin();
formLogin.ShowDialog(this);
```

Non impostare `MdiParent` su una form che vuoi aprire con `ShowDialog()`.

## Chiudere e nascondere le form

```csharp
this.Close();       // chiude la form corrente
this.Hide();        // la nasconde senza distruggerla
this.Show();        // mostra nuovamente una form nascosta
this.Dispose();     // libera manualmente le risorse
Application.Exit(); // termina tutta l'applicazione
```

Se chiudi la form passata ad `Application.Run(...)`, normalmente termina l'applicazione:

```csharp
Application.Run(new FormPrincipale());
```

Per nascondere temporaneamente la principale e ripristinarla alla chiusura della seconda:

```csharp
private void btnApri_Click(object sender, EventArgs e)
{
    FormSecondaria form = new FormSecondaria();

    Hide();
    form.FormClosed += Form_FormClosed;
    form.Show();
}

private void Form_FormClosed(object sender, FormClosedEventArgs e)
{
    Show();
}
```

## Intercettare la chiusura

### Chiedere conferma

```csharp
private void FormPrincipale_FormClosing(
    object sender,
    FormClosingEventArgs e)
{
    DialogResult risposta = MessageBox.Show(
        "Vuoi davvero uscire?",
        "Conferma",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (risposta == DialogResult.No)
    {
        e.Cancel = true;
    }
}
```

### Controllare il motivo della chiusura

```csharp
if (e.CloseReason == CloseReason.UserClosing)
{
    // Chiusura tramite X oppure Close()
}
```

Valori utili:

```csharp
CloseReason.UserClosing
CloseReason.ApplicationExitCall
CloseReason.WindowsShutDown
CloseReason.MdiFormClosing
CloseReason.FormOwnerClosing
CloseReason.TaskManagerClosing
```

## Passare dati tra form

### Attraverso il costruttore

```csharp
FormCliente form = new FormCliente("Andrea");
form.ShowDialog();
```

```csharp
private string nome;

public FormCliente(string nomeRicevuto)
{
    InitializeComponent();

    nome = nomeRicevuto;
    lblNome.Text = nome;
}
```

Usa il costruttore quando il dato è obbligatorio.

### Attraverso una proprietà

```csharp
FormCliente form = new FormCliente();
form.Nome = "Andrea";
form.Show();
```

```csharp
public string Nome
{
    get;
    set;
}
```

### Restituire un valore da una finestra modale

Nella form secondaria:

```csharp
public string NomeInserito
{
    get;
    private set;
}

private void btnConferma_Click(object sender, EventArgs e)
{
    NomeInserito = txtNome.Text;
    DialogResult = DialogResult.OK;
    Close();
}
```

Nella form principale:

```csharp
using (FormInserimento form = new FormInserimento())
{
    if (form.ShowDialog(this) == DialogResult.OK)
    {
        MessageBox.Show(form.NomeInserito);
    }
}
```

### Pulsanti predefiniti

```csharp
AcceptButton = btnConferma;
CancelButton = btnAnnulla;

btnConferma.DialogResult = DialogResult.OK;
btnAnnulla.DialogResult = DialogResult.Cancel;
```

In questo modo `Invio` conferma ed `Esc` annulla.

## Incorporare una form dentro un Panel

```csharp
private Form formCorrente;

private void ApriNelPanel(Form nuovaForm)
{
    if (formCorrente != null)
    {
        formCorrente.Close();
    }

    formCorrente = nuovaForm;

    nuovaForm.TopLevel = false;
    nuovaForm.FormBorderStyle = FormBorderStyle.None;
    nuovaForm.Dock = DockStyle.Fill;

    panelContenitore.Controls.Clear();
    panelContenitore.Controls.Add(nuovaForm);

    nuovaForm.BringToFront();
    nuovaForm.Show();
}
```

Utilizzo:

```csharp
private void btnClienti_Click(object sender, EventArgs e)
{
    ApriNelPanel(new FormClienti());
}
```

Se le pagine devono sempre stare dentro il pannello, normalmente un `UserControl` è più appropriato di una `Form`.

## Proprietà meno ovvie delle form

```csharp
StartPosition = FormStartPosition.CenterScreen;
StartPosition = FormStartPosition.CenterParent;

WindowState = FormWindowState.Maximized;
WindowState = FormWindowState.Minimized;
WindowState = FormWindowState.Normal;

FormBorderStyle = FormBorderStyle.FixedSingle;
FormBorderStyle = FormBorderStyle.None;

MaximizeBox = false;
MinimizeBox = false;
ControlBox = false;

TopMost = true;
ShowInTaskbar = false;
Opacity = 0.90;
KeyPreview = true;
```

Con `KeyPreview = true` la form riceve gli eventi della tastiera prima dei controlli:

```csharp
private void Form1_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Escape)
    {
        Close();
    }

    if (e.Control && e.KeyCode == Keys.S)
    {
        Salva();
    }
}
```

## MessageBox

```csharp
MessageBox.Show("Operazione completata");
```

```csharp
MessageBox.Show(
    "Dati non validi",
    "Errore",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);
```

```csharp
DialogResult risposta = MessageBox.Show(
    "Eliminare il record?",
    "Conferma",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
);

if (risposta == DialogResult.Yes)
{
    // Elimina
}
```

## DateTime

### Creazione

```csharp
DateTime adesso = DateTime.Now;
DateTime oggi = DateTime.Today;
DateTime utc = DateTime.UtcNow;

DateTime data = new DateTime(2026, 10, 16);
DateTime dataOra = new DateTime(2026, 10, 16, 8, 30, 0);
```

L'ordine del costruttore è anno, mese, giorno, ora, minuti, secondi.

### Leggere le singole parti

```csharp
int giorno = data.Day;
int mese = data.Month;
int anno = data.Year;

int ora = data.Hour;
int minuti = data.Minute;
int secondi = data.Second;

DayOfWeek giornoSettimana = data.DayOfWeek;
```

### Aggiungere o sottrarre tempo

```csharp
DateTime domani = data.AddDays(1);
DateTime ieri = data.AddDays(-1);
DateTime meseProssimo = data.AddMonths(1);
DateTime annoProssimo = data.AddYears(1);
DateTime traDueOre = data.AddHours(2);
DateTime traTrentaMinuti = data.AddMinutes(30);
```

Questi metodi restituiscono una nuova data. Per modificare la variabile devi riassegnarla:

```csharp
data = data.AddDays(1);
```

### Confrontare le date

```csharp
if (data1 < data2)
{
    MessageBox.Show("data1 viene prima");
}

if (data1 > data2)
{
    MessageBox.Show("data1 viene dopo");
}

if (data1.Date == data2.Date)
{
    MessageBox.Show("È lo stesso giorno");
}
```

### Differenza tra date

```csharp
TimeSpan differenza = dataFine - dataInizio;

double giorni = differenza.TotalDays;
double ore = differenza.TotalHours;
double minuti = differenza.TotalMinutes;
int componenteGiorni = differenza.Days;
```

`Days` restituisce la componente dei giorni; `TotalDays` restituisce l'intera durata convertita in giorni, anche con decimali.

## Formattare le date

```csharp
data.ToString("dd/MM/yyyy");          // 16/10/2026
data.ToString("d/M/yyyy");            // 16/10/2026
data.ToString("yyyy-MM-dd");          // 2026-10-16
data.ToString("dd/MM/yyyy HH:mm");    // 16/10/2026 08:30
data.ToString("HH:mm:ss");            // 08:30:00
data.ToString("dddd");                // venerdì
data.ToString("dddd d MMMM yyyy");    // venerdì 16 ottobre 2026
data.ToString("O");                   // formato ISO completo
```

| Simbolo | Significato |
|---|---|
| `dd` | giorno |
| `MM` | mese |
| `yyyy` | anno |
| `HH` | ora da 0 a 23 |
| `hh` | ora da 1 a 12 |
| `mm` | minuti |
| `ss` | secondi |
| `dddd` | giorno della settimana |
| `MMMM` | nome completo del mese |

Errore classico:

```csharp
data.ToString("dd/mm/yyyy"); // mm indica i minuti
data.ToString("dd/MM/yyyy"); // MM indica il mese
```

## Convertire una stringa in DateTime

### Conversione semplice

```csharp
DateTime data = DateTime.Parse(txtData.Text);
```

`Parse()` genera un'eccezione se il testo non è valido.

### Conversione sicura

```csharp
DateTime data;

if (DateTime.TryParse(txtData.Text, out data))
{
    MessageBox.Show($"Data valida: {data:dd/MM/yyyy}");
}
else
{
    MessageBox.Show("Data non valida");
}
```

### Imporre il formato dd/MM/yyyy

Serve `using System.Globalization;`.

```csharp
DateTime data;

bool valida = DateTime.TryParseExact(
    txtData.Text,
    "dd/MM/yyyy",
    CultureInfo.GetCultureInfo("it-IT"),
    DateTimeStyles.None,
    out data
);

if (valida)
{
    MessageBox.Show($"Data valida: {data:dd/MM/yyyy}");
}
else
{
    MessageBox.Show("Usa il formato gg/mm/aaaa");
}
```

## DateTimePicker

```csharp
// Leggere il valore
DateTime dataScelta = dateTimePicker1.Value;

// Ignorare l'orario
DateTime soloData = dateTimePicker1.Value.Date;

// Impostare il valore
dateTimePicker1.Value = DateTime.Today;

// Limitare l'intervallo
dateTimePicker1.MinDate = new DateTime(2000, 1, 1);
dateTimePicker1.MaxDate = DateTime.Today;
```

### Formato personalizzato

```csharp
dateTimePicker1.Format = DateTimePickerFormat.Custom;
dateTimePicker1.CustomFormat = "dd/MM/yyyy";
```

Con data e ora:

```csharp
dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
```

Per usare `CustomFormat` devi impostare anche `Format = DateTimePickerFormat.Custom`.

### Selezionare solamente l'ora

```csharp
dateTimePicker1.Format = DateTimePickerFormat.Time;
dateTimePicker1.ShowUpDown = true;
```

### Data opzionale con DateTime nullable

```csharp
dateTimePicker1.ShowCheckBox = true;

DateTime? data = null;

if (dateTimePicker1.Checked)
{
    data = dateTimePicker1.Value;
}
```

## cw, stringhe verbatim e interpolazione

`cw` è lo snippet di Visual Studio per:

```csharp
Console.WriteLine();
```

In genere si scrive `cw` e si preme `Tab` due volte. `cw@"..."` non è sintassi C# valida.

### Stringa normale

```csharp
Console.WriteLine("Ciao Andrea");
```

### Stringa verbatim

`@` evita di dover raddoppiare i backslash:

```csharp
Console.WriteLine(@"C:\Utenti\Andrea\Documenti");
```

Senza `@`:

```csharp
Console.WriteLine("C:\\Utenti\\Andrea\\Documenti");
```

Le virgolette dentro una stringa verbatim si raddoppiano:

```csharp
Console.WriteLine(@"Andrea ha detto: ""Ciao""");
```

### Stringa interpolata

```csharp
string nome = "Andrea";
int eta = 18;

Console.WriteLine($"Mi chiamo {nome} e ho {eta} anni");
Console.WriteLine($"Oggi è il {DateTime.Today:dd/MM/yyyy}");
Console.WriteLine($"Data e ora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
```

### Stringa interpolata e verbatim

```csharp
string nomeFile = "studenti.txt";
DateTime oggi = DateTime.Today;

Console.WriteLine(
    $@"Percorso: C:\Scuola\Informatica\{nomeFile}
Data: {oggi:dd/MM/yyyy}"
);
```

`$@"..."` e `@$"..."` sono equivalenti:

```csharp
string percorso = $@"C:\Backup\{DateTime.Today:yyyy-MM-dd}";
```

## Documentazione ufficiale

- [Creare una form MDI parent](https://learn.microsoft.com/dotnet/desktop/winforms/advanced/how-to-create-mdi-parent-forms)
- [Proprietà Form.MdiParent](https://learn.microsoft.com/dotnet/api/system.windows.forms.form.mdiparent)
- [Disporre le form MDI](https://learn.microsoft.com/dotnet/desktop/winforms/advanced/how-to-arrange-mdi-child-forms)
- [Classe DateTimePicker](https://learn.microsoft.com/dotnet/api/system.windows.forms.datetimepicker)
- [Proprietà DateTimePicker.CustomFormat](https://learn.microsoft.com/dotnet/api/system.windows.forms.datetimepicker.customformat)
