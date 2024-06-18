using System;
using System.Drawing;
using System.Windows.Forms;

public static class InputBox
{
    public static string Show(string title, string promptText)
    {
        // Створення нової форми
        Form form = new Form();

        // Компоненти форми
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();
        Button buttonCancel = new Button();

        // Налаштування властивостей компонентів
        form.Text = title; // Заголовок форми
        label.Text = promptText; // Текст підказки
        textBox.Text = ""; // Початковий текст у текстовому полі

        buttonOk.Text = "OK"; // Текст кнопки OK
        buttonCancel.Text = "Cancel"; // Текст кнопки Cancel
        buttonOk.DialogResult = DialogResult.OK; // Результат натискання OK
        buttonCancel.DialogResult = DialogResult.Cancel; // Результат натискання Cancel

        // Розміщення компонентів на формі
        label.SetBounds(9, 20, 372, 13); // Позиція і розміри мітки
        textBox.SetBounds(12, 36, 372, 20); // Позиція і розміри текстового поля
        buttonOk.SetBounds(228, 72, 75, 23); // Позиція і розміри кнопки OK
        buttonCancel.SetBounds(309, 72, 75, 23); // Позиція і розміри кнопки Cancel

        // Налаштування вигляду і поведінки компонентів
        label.AutoSize = true; // Автоматичний розмір мітки
        textBox.Anchor = AnchorStyles.Right; // Прив'язка текстового поля до правого краю форми
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; // Прив'язка кнопки OK до нижнього та правого краю форми
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; // Прив'язка кнопки Cancel до нижнього та правого краю форми

        // Налаштування розмірів форми
        form.ClientSize = new Size(396, 107); // Розміри форми
        form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel }); // Додавання компонентів до форми
        form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height); // Налаштування розміру форми з урахуванням компонентів
        form.FormBorderStyle = FormBorderStyle.FixedDialog; // Форма з фіксованим типом рамки
        form.StartPosition = FormStartPosition.CenterScreen; // Початкова позиція форми по центру екрану
        form.MinimizeBox = false; // Вимкнення кнопки мінімізації вікна
        form.MaximizeBox = false; // Вимкнення кнопки максимізації вікна
        form.AcceptButton = buttonOk; // Кнопка OK відповідає за підтвердження
        form.CancelButton = buttonCancel; // Кнопка Cancel відповідає за відміну

        // Показ діалогового вікна і очікування результату
        DialogResult dialogResult = form.ShowDialog();

        // Повернення тексту з текстового поля або null, якщо була вибрана кнопка Cancel
        return dialogResult == DialogResult.OK ? textBox.Text : null;
    }
}
