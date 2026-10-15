--[================================[
@Language.ko-KR
@Summary
[Player]의 [Unit] 데스값을 반환합니다.
@Group
일반
@param.Unit.TrgUnit
데스값을 가져올 유닛입니다.
@param.Player.TrgPlayer
대상 플레이어입니다.


@Language.en-US
@Summary
Returns the death count of [Unit] for [Player].
@Group
General
@param.Unit.TrgUnit
Unit to get death count for.
@param.Player.TrgPlayer
Target player.

@Language.zh-CN
@Summary
返回 [Player] 的 [Unit] 死亡计数值。
@Group
一般
@param.Unit.TrgUnit
要获取死亡计数的单位。
@param.Player.TrgPlayer
目标玩家。
]================================]
function GetDeaths(Unit, Player) -- 일반/TrgUnit,TrgPlayer/[Player]의 [Unit] 데스값을 반환합니다.
    Unit = ParseUnit(Unit)
    Player = ParsePlayer(Player)

    str = string.format("dwread_epd(%s * 12 + %s)", Unit, Player)
    echo(str)
end
