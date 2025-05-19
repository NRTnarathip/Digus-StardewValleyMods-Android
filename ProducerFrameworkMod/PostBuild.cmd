
set AppName=abc.smapi.gameloader

adb shell am force-stop %AppName%

if errorlevel 1 (
    echo ADB is not connected.
    exit /b
)

adb push "bin/Debug/net6.0/ProducerFrameworkMod.dll" "/storage/emulated/0/Android/data/%AppName%/files/Mods/ProducerFrameworkMod"

adb shell am start -n %AppName%"/crc64e91f1276c636690c.LauncherActivity" --ez "IsClickStartGame" true
