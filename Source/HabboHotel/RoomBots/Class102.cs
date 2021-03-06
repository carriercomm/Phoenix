using System;
using Phoenix.HabboHotel.GameClients;
using Phoenix.Messages;
using Phoenix.HabboHotel.Rooms;
namespace Phoenix.HabboHotel.RoomBots
{
	internal sealed class Class102 : Class99
	{
		private int int_2;
		private int int_3;
		public Class102()
		{
			this.int_2 = 0;
			this.int_3 = 0;
		}
		public override void OnSelfEnterRoom()
		{
			base.method_2().method_1(null, PhoenixEnvironment.GetExternalText("guidebot_welcome1"), true);
			base.method_2().method_1(null, PhoenixEnvironment.GetExternalText("guidebot_welcome2"), false);
		}
		public override void OnSelfLeaveRoom(bool bool_0)
		{
		}
		public override void OnUserEnterRoom(Class33 class33_0)
		{
		}
		public override void OnUserLeaveRoom(GameClient class16_0)
		{
			if (base.method_1().Owner.ToLower() == class16_0.GetHabbo().Username.ToLower())
			{
				base.method_1().method_6(base.method_2().int_0, false);
			}
		}
		public override void OnUserSay(Class33 class33_0, string string_0)
		{
			if (base.method_1().method_100(base.method_2().int_3, base.method_2().int_4, class33_0.int_3, class33_0.int_4) <= 8)
			{
				Class35 @class = base.method_3().method_2(string_0);
				if (@class != null)
				{
					string text = base.method_1().method_20(class33_0, @class.string_0);
					string text2 = @class.string_1.ToLower();
					if (text2 != null)
					{
						if (!(text2 == "say"))
						{
							if (!(text2 == "shout"))
							{
								if (text2 == "whisper")
								{
									ServerMessage gClass = new ServerMessage(25u);
									gClass.AppendInt32(base.method_2().int_0);
									gClass.AppendStringWithBreak(text);
									gClass.AppendBoolean(false);
									class33_0.method_16().method_14(gClass);
								}
							}
							else
							{
								base.method_2().method_1(null, text, true);
							}
						}
						else
						{
							base.method_2().method_1(null, text, false);
						}
					}
					if (@class.int_0 >= 1)
					{
						class33_0.method_8(@class.int_0);
					}
				}
			}
		}
		public override void OnUserShout(Class33 class33_0, string string_0)
		{
		}
		public override void OnTimerTick()
		{
			if (this.int_2 <= 0)
			{
				if (base.method_3() != null && base.method_3().list_0.Count > 0)
				{
					Class36 @class = base.method_3().method_3();
					base.method_2().method_1(null, @class.string_0, @class.bool_0);
				}
				this.int_2 = Phoenix.smethod_5(0, 150);
			}
			else
			{
				this.int_2--;
			}
			if (this.int_3 <= 0)
			{
				int int_ = Phoenix.smethod_5(0, base.method_1().Class28_0.int_4);
				int int_2 = Phoenix.smethod_5(0, base.method_1().Class28_0.int_5);
				base.method_2().method_5(int_, int_2);
				this.int_3 = Phoenix.smethod_5(0, 30);
			}
			else
			{
				this.int_3--;
			}
		}
	}
}
