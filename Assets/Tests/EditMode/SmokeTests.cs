using NUnit.Framework;
using UnityEngine;

namespace DungeonGO2.Tests.EditMode
{
    /// <summary>
    /// CI 파이프라인이 테스트를 찾아 실행하고 결과를 올리는지 확인하는 최소 테스트.
    /// 게임 로직 테스트는 전투 코드 어셈블리가 생기면 별도 파일로 추가한다.
    /// </summary>
    public class SmokeTests
    {
        [Test]
        public void TestRunner_Executes()
        {
            Assert.AreEqual(4, 2 + 2);
        }

        [Test]
        public void UnityVersion_IsExpectedMajorLine()
        {
            StringAssert.StartsWith("6000.3.", Application.unityVersion);
        }
    }
}
