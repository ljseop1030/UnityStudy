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
