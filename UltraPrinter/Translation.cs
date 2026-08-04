using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPrinter
{
    public class Translation
    {
        public static void TranslateUI(Label[] UIlabel, Button[] UIbutton, string[] UIAnswers, bool languege)
        {
            if (languege == true)
            {
                UIlabel[0].Text = "Выбранный файл:";
                UIlabel[1].Text = "Выбранный файл:";
                UIlabel[2].Text = "Выбранный файл:";
                UIlabel[3].Text = "Миниатюра изображения:";
                UIlabel[4].Text = "Размер принтинга:";
                UIlabel[5].Text = "Внимание! Выбор 256x256 сильно нагружает" +
                    "\r\nUltrakill. Выбор 512x512 и 1024х1024 потенциально" +
                    "\r\nмогут привести к зависанию игры";
                UIbutton[0].Text = "Выбрать файл для чтения (матрица, формат .txt)";
                UIbutton[1].Text = "Выбрать папку для сохранения карт";
                UIbutton[2].Text = "Выбрать изображение для чтения";
                UIbutton[3].Text = "Коневертировать матрицу в карту";
                UIbutton[4].Text = "Коневертировать изображение в карту";
                UIAnswers[0] = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                UIAnswers[1] = "Выберите папку для сохранения файла";
                UIAnswers[2] = "Файл UltraPrint.pitr создан!"; // 3 и 7 записи
                UIAnswers[3] = "Ошибка создания файла UltraPrint.pitr!"; // 4 и 8 записи
                UIAnswers[4] = "Не был выбран файл принта или папка для сохранения!";
                UIAnswers[5] = "Изображения|*.jpg;*.png;*.bmp|Все файлы|*.*";
                UIAnswers[6] = "Не был выбран изображение принта или папка для сохранения!";
            }
            else
            {
                UIlabel[0].Text = "Selected file:";
                UIlabel[1].Text = "Selected file:";
                UIlabel[2].Text = "Selected file:";
                UIlabel[3].Text = "Miniature image:";
                UIlabel[4].Text = "Size of printing:";
                UIlabel[5].Text = "Warning! Select 256x256 heavily load the" +
                    "\r\nUltrakill. Select 512x512 and 1024х1024 potentially" +
                    "\r\nmay lead to total game freeze";
                UIbutton[0].Text = "Select file for reading (matrix, format .txt)";
                UIbutton[1].Text = "Select folder to save a map";
                UIbutton[2].Text = "Select image for reading";
                UIbutton[3].Text = "Convert matrix to map";
                UIbutton[4].Text = "Convert image to map";
                UIAnswers[0] = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                UIAnswers[1] = "Select folder to save a map!";
                UIAnswers[2] = "File UltraPrint.pitr created!"; // 3 и 7 записи
                UIAnswers[3] = "Error creating file UltraPrint.pitr!"; // 4 и 8 записи
                UIAnswers[4] = "File of printing or folder to save was not selected!";
                UIAnswers[5] = "Images|*.jpg;*.png;*.bmp|All files|*.*";
                UIAnswers[6] = "Image to printing or folder to save was not selected!";
            }
        }
    }
}
