<h1>Hi all / Всем привет</h1>

This is my first Qurre plugin / Это мой первый плагин для Qurre


I updated it and now you can configure the hitmarker for your server in more detail / Я его обновил и теперь вы можете более детально настроить хитмаркер для своего сервера

Let's start! / Давайте начнем!


<b><i>Installation / Установка</i></b>

Just put <code>EasyHitMarker.dll</code> in the folder <code>.../Qurre/Plugins</code> and start the server, the configuration file will appear (update) itself / Просто поместите <code>EasyHitMarker.dll</code> в папку <code>.../Qurre/Plugins</code> и запустите сервер, файл конфигурации появится (обновится) сам


<b><i>Configuration / Конфигурация</i></b>

<code>hitmarker_plugin_name: EasyHitMarker</code> (Just plugin name / Просто название плагина)

<code>hitmarker_enable: true</code> (On or off plugin / Включить или выключить плагин)

<code>hitmarker_hint_message: -<color=#F51FDE>{damageamount}</color> HP</code> (The message itself that is shown when dealing damage / Само сообщение которое показывается при нанесении урона)

<code>hitmarker_hint_duration: 1.5</code> (The duration of the displayed hint in seconds / Длительность отображаемого хинта в секундах)


<i><b>New functionality / Новый функционал</i></b>

To randomize the display of hints on the screen, 2 int values are used - <code>hitmarker_randShow1</code> and <code>hitmarker_randShow2</code> / Для рандомизации отображения хинтов на экране используются 2 значения int — <code>hitmarker_randShow1</code> и <code>hitmarker_randShow2</code>

And what about random? / И причем здесь рандом?

Look at the hint output line / Посмотрите на строку вывода хинта

<code>"<pos={r.Next(rand1, rand2)}%>{message}"</code>

And now look at the this documentation / А теперь посмотрите на эту документацию

![image](https://user-images.githubusercontent.com/57017651/180650926-1991a16d-fb65-402b-b019-439bae0b115c.png)

I think everything is clear here / Я думаю что тут все и так понятно

![image](https://user-images.githubusercontent.com/57017651/180650376-4079a58d-90b7-4d9a-935b-c96bea3da818.png)


<b><i>Presentation / Презентация</i></b>

Starting a server with a hitmarker plugin / Запуск сервера с плагином хитмаркер

![image](https://user-images.githubusercontent.com/57017651/180650471-cc67c81f-c8ed-45dd-83cf-5baddcb077ec.png)

Launch error because the plugin is disabled in the config / Ошибка запуска, так как плагин выключен в конфиге

![image](https://user-images.githubusercontent.com/57017651/178643030-d78116bd-8311-4933-9694-ace79c686fc7.png)

In action / В действии

![SCPSL 2022-07-13 10-10-47 (online-video-cutter com)](https://user-images.githubusercontent.com/57017651/178644488-939d7702-857d-4ba4-8dd8-138e658cf0e9.gif)



