# tutorial 1.1강 - 3D 엔진 시작

## 유니티에서 보라색 뭉탱이 나올 때 체크리스트:

**1. 렌더 파이프라인 문제인지 확인**
- Edit → Project Settings → Graphics 들어가기
- "Scriptable Render Pipeline Settings"에 뭔가 할당되어 있으면 렌더 파이프라인 충돌임
- 패키지가 Built-in용인데 프로젝트는 URP/HDRP거나 그 반대

**2. 해결 방법 선택**
- 튜토리얼 따라하는 중이면? → 렌더 파이프라인 **제거**해서 Built-in으로 되돌리기 (None으로 만들기)
- 실제 프로젝트 작업 중이면? → 머티리얼을 현재 파이프라인에 맞게 **변환**하기 (Edit → Render Pipeline → Upgrade...)

**3. 빠른 체크 순서**
1. Console 창 열어서 에러 확인 (빨간 줄 있나?)
2. Graphics Settings 확인 (렌더 파이프라인 할당 상태)
3. 씬 뷰를 Wireframe 모드로 바꿔서 모델 형태는 보이는지 확인

**4. 기억할 것**
- 보라색 = 쉐이더/머티리얼 오류
- 대부분 렌더 파이프라인 불일치 문제
- Built-in ↔ URP/HDRP 섞으면 무조건 터짐
- 초보 튜토리얼은 거의 Built-in 기준

앞으로 임포트 전에 "이 패키지가 어떤 렌더 파이프라인용인지" 확인하는 습관 들이면 좋다.

**해결방안2**
🛠️
유니티에는 자동으로 옛날 재질을 최신 방식으로 바꿔주는 기능이 있습니다. 순서대로 따라 해보세요.

1. 유니티 상단 메뉴에서 Window > Rendering > Render Pipeline Converter를 클릭합니다.
(만약 메뉴가 없다면 Edit > Rendering > Materials > Convert All Built-in Materials to URP를 찾아보세요)

2. 창이 뜨면 Dropdown 메뉴에서 Built-in to URP를 선택합니다.
목록에 있는 체크박스들(특히 Material Upgrade)을 모두 체크합니다.

3. 왼쪽 아래 Initialize Converters 버튼을 누릅니다.

4. 잠시 후 오른쪽 아래 Convert Assets 버튼이 활성화되면 클릭합니다.

5. 이렇게 하면 핑크색이 사라지고 정상적인 색깔(초록 들판, 비행기 등)이 나올 것입니다.

## Input issue
Edit → Project Settings → Player → Other Settings → Active Input Handling : Both

## 단축키

우클릭 + WASD : 시점 이동
Hierarchy에서 오브젝트 선택 + F : 오브젝트 맞춤 시점으로 이동
Scroll Wheel 사용
Alt + 좌클릭 : 초점 주위로 회전
Alt + 우클릭 : 확대 및 축소
Ctrl/Cmd+Z
QWERTY : 도구 왔다갔다 가능