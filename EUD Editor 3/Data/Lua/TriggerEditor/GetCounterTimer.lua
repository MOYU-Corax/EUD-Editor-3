--[================================[
@Language.ko-KR
@Summary
현재 카운트 타이머를 반환합니다.
@Group
시스템


@Language.en-US
@Summary
Returns the current counter timer value.
@Group
System

@Language.zh-CN
@Summary
返回当前计数计时器。
@Group
系统
]================================]
function GetCounterTime() --일반//현재 카운트 타이머를 반환합니다.
	echo("dwread(0x58D6F4)")
end

--[================================[
@Language.ko-KR
@Summary
현재 카운트 타이머 주소를 반환합니다.
@Group
시스템


@Language.en-US
@Summary
Returns the address of the current counter timer.
@Group
System

@Language.zh-CN
@Summary
返回当前计数计时器的地址。
@Group
系统
]================================]
function CounterTimeOffset() --일반//현재 카운트 타이머 주소를 반환합니다.
	echo("0x58D6F4")
end
