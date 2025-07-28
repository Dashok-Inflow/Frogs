# Frogs
🐸 Игра «Лягушки», созданная в процессе изучения технологии Windows Forms и работы с изображениями
## Описание
### ❗Правила игры
Цель игры — расположить лягушек, которые смотрят влево, в левую часть, а остальных - в правую часть за минимальное количество перепрыгиваний.

Прыгать можно на листок, если он находится рядом или через 1 лягушку
### Пример работы приложения
![ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/9b038b9a-74f6-4058-b3bd-c37345334bbf)

## Техническая часть
* Проект реализован на платформе Windows Forms
* Для работы с картинками был использован PictureBox
* Меню создано с помощью MenuStrip
* Если пользователь решает _нарушить правила_ , то  с помощью MessageBox появляется окно с предупреждением
### Архитктура
Структура каталога решения:

<img width="392" height="541" alt="image" src="https://github.com/user-attachments/assets/9db67152-f1a2-4c30-9412-51214d2dde58" />

### ⚙️Механика работы
Чтобы лягушки перемещались, каждый PictureBox был подписан на событие **PictureBox_Click**, за исключением пустой кувшинки. Данное событие содержит методы **Swap** и **EndGame**, в которых прописана логика перемещения лягушек и проверка конца игры соответственно

* Событие PictureBox_Click
<pre><code>private void PictureBox_Click(object sender, EventArgs e)
{
    score++;
    scoreLabel.Text = score.ToString();
    Swap((PictureBox)sender);
}
</code></pre>
* Метод Swap
 <pre><code>private void Swap(PictureBox clickedPicture)
{
    var distance=Math.Abs(clickedPicture.Location.X-emptyPictureBox.Location.X)/emptyPictureBox.Size.Width;

    if (distance>2)
    {
        MessageBox.Show("Лягушка не умеет прыгать так далеко!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
    }
    else
    {
        var location = clickedPicture.Location;
        clickedPicture.Location = emptyPictureBox.Location;
        emptyPictureBox.Location = location;

        if (EndGame())
        {
            if (score == bestScore)
            {
                MessageBox.Show("Игра окончена!\nВы победили с лучшим счётом!");
            }
            else
            {
                MessageBox.Show("Игра окончена!\nВы победили, но не за минимальное количество ходов!\nМинимальное количество: 24");
            }
        }
    }
}
</code></pre>
* Метод EndGame
<pre><code>private bool EndGame()
{
    return rightPictureBox1.Location.X < emptyPictureBox.Location.X && rightPictureBox2.Location.X < emptyPictureBox.Location.X 
        && rightPictureBox3.Location.X < emptyPictureBox.Location.X && rightPictureBox4.Location.X < emptyPictureBox.Location.X 
        && emptyPictureBox.Location.X == 450;
}
</code></pre>
