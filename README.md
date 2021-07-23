# Bladestorm
![](https://user-images.githubusercontent.com/42521703/126815379-0857a50d-61c5-40e4-bd28-325c5c4216ad.png)

## Overview
Bladestorm is VALORANT's overlay system for esports streaming.
It is able to use software to display team names, MAP score numbers, and match names, all of which are essential for Esport streaming.

<!-- ## Installation
First Download [UnityCapture](https://github.com/schellingb/UnityCapture) from GitHub with the [`Download ZIP`](https://github.com/schellingb/UnityCapture/archive/master.zip) button or by cloning the repository. -->

---
## 概要
BladestormはVALORANTのEsports配信向けのオーバーレイシステムです。
Esports配信で欠かせないチーム名やマッチ名、得失MAP数の表示などをソフトウェアによって簡単に行うことができます。

## インストール
### UnityCaputureのインストール
1. まず [UnityCapture](https://github.com/schellingb/UnityCapture) をGitHubの [`Download ZIP`](https://github.com/schellingb/UnityCapture/archive/master.zip) ボタンを押してダウンロードするか、Gitを用いてリポジトリをcloneします。

2. ダウンロードした `UnityCapture` のフォルダを開き、`Install` フォルダをの中の `Install.bat` を実行します(要管理者権限)。

### Bladestormのインストール
1. 次にこのプロジェクトの [Release](https://github.com/3rdJCG/Bladestorm/releases/) を開き、最新のバージョンの `Assets` カラムを開き `Bladestorm.zip` をダウンロードします。

2. ダウンロードしたZIPファイルを展開し、`Bladestorm.exe` を実行します。

## 使い方
1. まずOBS Studioを開き、任意の方法でVALORANTのゲーム画面をキャプチャします。

2. 次にBladestormを起動し、その状態でOBSを開き、 `ソースを追加` をクリックし、`映像キャプチャデバイス` を選択します。
   開いたポップアップでデバイスを選択できるので、`Unity Video Capture` を選択し、追加します。

3. 追加した `映像キャプチャデバイス` のフィルタータブを開き、`エフェクトフィルター` から `クロマキー` を追加します。
   色キーの種類を `Custom` にし、キーの色は `#0000FF` として類似性は `0` に設定することを推奨します。

4. Bladestormのウィンドウから、各種項目を入力すると即座にOBSに反映されます。

5. 設定のウィンドウを閉じてしまった場合は、`F10` キーで戻すことができます。


