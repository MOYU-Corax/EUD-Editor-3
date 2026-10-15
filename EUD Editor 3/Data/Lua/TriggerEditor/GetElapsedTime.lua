--[================================[
@Language.ko-KR
@Summary
게임 진행 시간을 반환합니다.
@Group
시스템


@Language.en-US
@Summary
Returns the elapsed game time.
@Group
System

@Language.zh-CN
@Summary
返回游戏进行时间。
@Group
系统
]================================]
function GetElapsedTime() --일반//게임 진행 시간을 반환합니다.
	echo("dwread(0x58D6F8)")
end

--[================================[
@Language.ko-KR
@Summary
게임 진행 시간 주소를 반환합니다.
@Group
시스템


@Language.en-US
@Summary
Returns the address of the elapsed game time.
@Group
System

@Language.zh-CN
@Summary
返回游戏进行时间的地址。
@Group
系统
]================================]
function ElapsedTimeOffset() --일반//게임 진행 시간 주소를 반환합니다.
	echo("0x58D6F8")
end
