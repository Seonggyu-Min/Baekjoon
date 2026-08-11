using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        // 제한 사항
        // fees.Length <= 4
        // 1 <= fees[0] (기본 시간) <= 1,439분 == 23시간 59분
        // 0 <= fees[1] (기본 요금) <= 100,000원
        // 1 <= fees[2] (단위 시간) <= 1,439분 == 23시간 59분
        // 1 <= fees[1] (단위 요금) <= 10,000원
        // 1 <= records.Length <= 10,000

        var basicTime = fees[0];
        var basicFee = fees[1];
        var unitTime = fees[2];
        var unitFee = fees[3];

        var LAST_TIME = 1_439;

        // Key 차 번호, Value 시간 (분) 저장
        // record가 IsIn = false면 출차 안된 차로 판단
        var dict = new Dictionary<int/*carNum*/, (Record record, int totalTime)>();

        // 입차/출차 기록 처리
        for (int i = 0; i < records.Length; i++)
        {
            var curRecord = new Record(records[i]);

            if (dict.TryGetValue(curRecord.CarNum, out var prevRecord))
            {
                // 직전 기록이 입차이고 지금 기록이 출차라면 시간 합산기록
                if (prevRecord.record.IsIn && !curRecord.IsIn)
                {
                    var sumTime = curRecord.Time - prevRecord.record.Time;

                    prevRecord.totalTime += sumTime;
                    prevRecord.record = curRecord;

                    dict[curRecord.CarNum] = prevRecord;
                }
                // 직전 기록이 출차이고 지금 기록이 입차라면 Record만 대입 기록
                else if (!prevRecord.record.IsIn && curRecord.IsIn)
                {
                    prevRecord.record = curRecord;

                    dict[curRecord.CarNum] = prevRecord;
                }
            }
            else
            {
                dict[curRecord.CarNum] = (curRecord, 0);
            }
        }

        // 입차만 하고 출차를 끝까지 안한 차들 마지막 출차 시간에 출차한 것으로 가정
        foreach (var key in dict.Keys.ToList())
        {
            var value = dict[key];

            if (value.record.IsIn)
            {
                var sumTime = LAST_TIME - value.record.Time;
                value.totalTime += sumTime;
                dict[key] = value;
            }
        }

        // 차량 번호가 작은 자동차부터 요금 배열로 반환
        var totalFee = new int[dict.Keys.Count];
        var idx = 0;

        foreach (var key in dict.Keys.Order())
        {
            var value = dict[key];
            int fee;

            if (value.totalTime <= basicTime)
            {
                fee = basicFee;
            }
            else
            {
                var extraTime = value.totalTime - basicTime;
                var unitCount = (extraTime + unitTime - 1) / unitTime;

                fee = basicFee + unitCount * unitFee;
            }

            totalFee[idx++] = fee;
        }

        return totalFee;
    }
    
        public struct Record
    {
        public int CarNum;
        public int Time;
        public bool IsIn;

        public Record(string s)
        {
            // 차 번호 변환
            CarNum = (s[6] - '0') * 1000 +
                (s[7] - '0') * 100 +
                (s[8] - '0') * 10 +
                (s[9] - '0') * 1;

            // 시간 변환
            Time = (s[0] - '0') * 600 + // 10시간 단위
                (s[1] - '0') * 60 + // 1시간 단위
                (s[3] - '0') * 10 + // 10분 단위
                (s[4] - '0'); // 1분 단위

            // 입차/출차 판단
            IsIn = s[11] == 'I';
        }
    }
}