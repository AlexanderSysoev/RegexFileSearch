Необходимо написать консольное приложение осуществляющее поиск заданного регулярного выражения в данных из двух видов источников (текстовый файл и excel файл).
Тип источника определяется по расширению (txt, xlsx).
Путь к файлу и регулярное выражение задаются как входные параметры в приложение.
Приложение, в ходе работы, выводит в лог важную информацию для отслеживания истории запуска и отладки ошибок.
После выполнения поиска приложение завершается с exit code 1 если выражение найдено и 0 в противном случае.
Для работы с xlsx файлами предпочтительно использовать библиотеку EPPlus. Возможен аргументированный выбор другой библиотеки.
Необходимо предусмотреть простоту поддержки и расширения данного приложения новыми видами источников
