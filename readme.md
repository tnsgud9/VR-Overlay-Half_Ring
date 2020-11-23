
<p align=center>
<img src="https://user-images.githubusercontent.com/26598708/63312262-e856cc00-c33b-11e9-8d1a-61c1098c5e61.png" width="70%"></img>
</p>

## 개발 의도
가상 현실 상에서의 **멀미 유발 요소들을 최소화**하여 VR 이용 환경에 최적하게 만드는 것
동시에 **VR상용화를 목표**로 하여 종국적으로 **VR 산업 발전에 기여**하고 싶다.

## 문제점 분석
VR을 장시간 체험해본 결과 VR기기들에 따라 **5 ~ 20분 이상 착용 시 VR멀미가 발생**하는 것을 알게 되었고 그 중에서도 특히 안드로이드 OS를 기반으로 한 VR기기들은 더욱 더 큰 멀미 증상을 보였다.

현재 VR의 대중화에 있어 어떤 부분들이 문제점인지 통계를 찾아본 결과. 사용자의 경험 중 기술적 요인과 인해 **멀미, 매스꺼움의 증상**들로 인해 VR의 이용률이 낮은 것을 정보통신진흥센터의 통계를 통해 알 수 있었다. VR콘텐츠 속에서 플레이어의 시점 이동이 많고 시선을 많이 움직이면 가상현실 속에서는 이동하지만 몸은 움직이고 있지 않기 때문에 전정기관(前庭器官)의 상호인지 부조화로 인해 VR멀미가 짧은 시간 내 발생한다는 것을 알게 되었고, 우리는 곧바로 **전정 기관의 상호 조화를 맞추는데 초점을 잡았다.**

## 해결 솔루션
<img src="https://user-images.githubusercontent.com/26598708/63315081-d9c0e280-c344-11e9-9c6e-0ac615bf937d.gif" width="60%"></img> 

 시트로앵(CITROËN)이란 자동차 회사 사에서 개발한 멀미 방지 안경이 안경테의 파란색 액체가 절반만 채워져 수평선이 시각적으로 보이게 하는 원리를 이용해 멀미를 해소하는 제품을 **벤치마크** 했다.
 
<img src="https://user-images.githubusercontent.com/26598708/63314981-64551200-c344-11e9-80b5-075e27db83a8.png" width="40%"></img> 

원호의 이미지가 VR화면에 오버레이 된다.  VR기기의 IMU센서  값을 STEAM VR로 받아 원호 모양의 이미지가 항상 z축(아래쪽)을 향하도록 만들어 멀미에 대한 솔루션을 구성했다.

이러한 이미지는 하나의 수평선의 역할을 하여 멀미 빈도를 줄이며 사용자들의 원활한 VR사용에 도움을 준다.

## 개발
Unity와 SteamVR API를 이용해 개발을 진행했으며
GitHub에 공개된 HeadlessOverlayToolkit 프로젝트를 베이스로 개발을 진행했다.
Unity 2018로 프로젝트를 업그레이드 하는 과정에서 SteamVR API 또한 버젼에 맞는 소스로 수정했다. 
UnityRawInput을 통해 다른 프로그램에 Focus가 된 상태에서도 특정 키를 누르면 오버레이 기능을 껏다 킬 수 있다. ( 현재 추가 되진 않음 )

핵심 구현을 위해 추가로 작성한 C# 코드 파일들

`OverlayRing.cs`
`SettingManager.cs`
`UI_Manager.cs`

OverlayRing.cs는 HOTK_TrackedDevice.cs로 회전하는 carmera 오브젝트에 따라 값을 받는다.


### ( 출처 ) 
Hotrian/HeadlessOverlayToolkit : [https://github.com/Hotrian/HeadlessOverlayToolkit](https://github.com/Hotrian/HeadlessOverlayToolkit)

Elringus/UnityRawInput : [https://github.com/Elringus/UnityRawInput](https://github.com/Elringus/UnityRawInput)

##  결과
<img src ="https://github.com/tnsgud9/VR-Overlay-Half_Ring/blob/master/Assets/Half-Ring/Sprites/gif/1.gif?raw=true" width="30%"></img>

IMU 센서 중 가속도 센서 기반으로 작동된다.

### 핵심코드
##### OverlayRing.cs
<pre><code>
    //Important : It is handled first. (Maximum Priority in define to Script Execution Order)
    //중요 : 가장 먼저 처리된다.( 최고 우선 순위로 Script Execution Order에 지정되어 있다. )
    void Update () {
        //Debug.Log("HMD Rotation : " + carmera.transform.eulerAngles);
        overlayOBJ.gameObject.transform.rotation = Quaternion.Euler(0 , 0, 360f-carmera.transform.eulerAngles.z);
    }</code></pre>

## 추가 기능
VR Half Ring은 3차 테스팅 및 피드백 당시 **원호가 거슬린다**는 의견을 받았다.
이를 해결하기 위해 3가지 **오버레이 기능 추가**했다. 

|<img src="https://github.com/tnsgud9/VR-Overlay-Half_Ring/blob/master/Assets/Half-Ring/Sprites/gif/3.gif?raw=true" ></img>|<img src="https://github.com/tnsgud9/VR-Overlay-Half_Ring/blob/master/Assets/Half-Ring/Sprites/gif/4.gif?raw=true" ></img>|<img src="https://github.com/tnsgud9/VR-Overlay-Half_Ring/blob/master/Assets/Half-Ring/Sprites/gif/2.gif?raw=true">|
|:--------:|:--------:|:--------:|
|모양 변경|색상 변경| 위아래를 바라볼때<br>일시적 기능 해제|


## 결과
( 추가 될 예정 )
멀미를 약70% 정도 해결 할 수 있었다.

## 여담
아직 멀미는 과학적으로 어떻게 발생하는지 모른다.
VR 멀미를 해결하기 위해 우리는 VR멀미를 해소 할 수 있는 방법들은 다양하게 도입해볼 예정이다.

#

<h3> 2019년 제 13회 서울시 창의 아이디어 경진 대회 송파공업고등학교 Vision Render 팀 출품작 </h3>
<p align=center>
<img src="https://postfiles.pstatic.net/MjAxOTA1MDlfMjI2/MDAxNTU3MzkxMTc3ODMw.4WQIMf6xRfVnlHC8cEE-OdhOCGeodYF5TkfaOdJp0MQg.QJeESmRkwv1rB9vlgIVea_ZESY5SMp_gf7R36tcB_U8g.JPEG.2019sca/%EC%8A%AC%EB%9D%BC%EC%9D%B4%EB%93%9C1.JPG?type=w966" width=50% >

</p>
