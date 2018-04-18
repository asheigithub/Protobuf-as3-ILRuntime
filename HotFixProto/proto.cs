using System;
namespace SProtoSpace
{
	public class account_repeated_tick_ntf : AS3Proto.Message
	{
		public account_repeated_tick_ntf()
		{
			createAs3Object("SProtoSpace.account_repeated_tick_ntf");
		}

		private account_repeated_tick_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static account_repeated_tick_ntf Create(object rtObject)
		{
			return new account_repeated_tick_ntf((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class area_list_info_ack : AS3Proto.Message
	{
		public area_list_info_ack()
		{
			createAs3Object("SProtoSpace.area_list_info_ack");
		}

		private area_list_info_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static area_list_info_ack Create(object rtObject)
		{
			return new area_list_info_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.Collections.Generic.List<SProtoSpace.gate_net_info> groupNetInfo ;
		public string account ;
		public void clearCheckServerId(){ player.invokeMethod(as3Object, "clearCheckServerId");}
		public bool hasCheckServerId{get { return (bool)((player.getMemberValue(as3Object, "hasCheckServerId"))); }}
		public uint checkServerId{get { return (uint)((player.getMemberValue(as3Object, "checkServerId"))); }set { player.setMemberValue(as3Object, "checkServerId", (value)); }}
		public System.Collections.Generic.List<SProtoSpace.group_area_info> areaGroups ;
		public System.Collections.Generic.List<SProtoSpace.group_area_info> recommendAreas ;
		public void clearMyLoginAreas(){ player.invokeMethod(as3Object, "clearMyLoginAreas");}
		public bool hasMyLoginAreas{get { return (bool)((player.getMemberValue(as3Object, "hasMyLoginAreas"))); }}
		private SProtoSpace.group_area_info ___myLoginAreas; private bool ___myLoginAreasflag___;
		public SProtoSpace.group_area_info myLoginAreas
		{
			get
			{
				if (___myLoginAreas == null && !___myLoginAreasflag___)
				{
					___myLoginAreasflag___ = true;
					var obj = player.getMemberValue(as3Object, "myLoginAreas");
					if(obj !=null)
						___myLoginAreas = SProtoSpace.group_area_info.Create(obj);
				}

				return ___myLoginAreas;
			}
			set
			{
				___myLoginAreas = value;
				if (value != null)
				{
					player.setMemberValue(as3Object, "myLoginAreas", LoadBindObject(value));
				}
				else
				{
					player.setMemberValue(as3Object, "myLoginAreas", null);
				}
			}
		}
		public System.Collections.Generic.List<SProtoSpace.group_hero_info> myGroupPlayers ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			{
				groupNetInfo = new System.Collections.Generic.List<SProtoSpace.gate_net_info>();
				uint len = (uint)player.getMemberValue(as3Object, "groupNetInfo.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.gate_net_info v = default(SProtoSpace.gate_net_info);
					{
						var obj = player.getMemberValue(as3Object, "groupNetInfo",i);
						if (obj !=null)
							v = SProtoSpace.gate_net_info.Create(obj);
						else
							v = null;
					}

					groupNetInfo.Add(v);
				}
			}
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			{
				areaGroups = new System.Collections.Generic.List<SProtoSpace.group_area_info>();
				uint len = (uint)player.getMemberValue(as3Object, "areaGroups.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.group_area_info v = default(SProtoSpace.group_area_info);
					{
						var obj = player.getMemberValue(as3Object, "areaGroups",i);
						if (obj !=null)
							v = SProtoSpace.group_area_info.Create(obj);
						else
							v = null;
					}

					areaGroups.Add(v);
				}
			}
			{
				recommendAreas = new System.Collections.Generic.List<SProtoSpace.group_area_info>();
				uint len = (uint)player.getMemberValue(as3Object, "recommendAreas.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.group_area_info v = default(SProtoSpace.group_area_info);
					{
						var obj = player.getMemberValue(as3Object, "recommendAreas",i);
						if (obj !=null)
							v = SProtoSpace.group_area_info.Create(obj);
						else
							v = null;
					}

					recommendAreas.Add(v);
				}
			}
			{
				myGroupPlayers = new System.Collections.Generic.List<SProtoSpace.group_hero_info>();
				uint len = (uint)player.getMemberValue(as3Object, "myGroupPlayers.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.group_hero_info v = default(SProtoSpace.group_hero_info);
					{
						var obj = player.getMemberValue(as3Object, "myGroupPlayers",i);
						if (obj !=null)
							v = SProtoSpace.group_hero_info.Create(obj);
						else
							v = null;
					}

					myGroupPlayers.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			{
				player.setMemberValue(as3Object, "groupNetInfo.length", groupNetInfo.Count);
				for (int i = 0; i < groupNetInfo.Count; i++)
				{
					var v = groupNetInfo[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "groupNetInfo", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "groupNetInfo", null);
						}
					}
					
				}
			}
			player.setMemberValue(as3Object, "account", (account) );
			{
				player.setMemberValue(as3Object, "areaGroups.length", areaGroups.Count);
				for (int i = 0; i < areaGroups.Count; i++)
				{
					var v = areaGroups[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "areaGroups", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "areaGroups", null);
						}
					}
					
				}
			}
			{
				player.setMemberValue(as3Object, "recommendAreas.length", recommendAreas.Count);
				for (int i = 0; i < recommendAreas.Count; i++)
				{
					var v = recommendAreas[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "recommendAreas", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "recommendAreas", null);
						}
					}
					
				}
			}
			{
				player.setMemberValue(as3Object, "myGroupPlayers.length", myGroupPlayers.Count);
				for (int i = 0; i < myGroupPlayers.Count; i++)
				{
					var v = myGroupPlayers[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "myGroupPlayers", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "myGroupPlayers", null);
						}
					}
					
				}
			}
				{
					var value = ___myLoginAreas;
					if (value != null)
					{
						player.setMemberValue(as3Object, "myLoginAreas", LoadBindObjectAndWriteField(value));
					}
					else
					{
						player.setMemberValue(as3Object, "myLoginAreas", null);
					}
				}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class backup_force_info : AS3Proto.Message
	{
		public backup_force_info()
		{
			createAs3Object("SProtoSpace.backup_force_info");
		}

		private backup_force_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static backup_force_info Create(object rtObject)
		{
			return new backup_force_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public int totalAttrHp ;
		public int totalAttrAttack ;
		public int totalAttrDefense ;
		public int totalAttrCrit ;
		public int totalAttrCritDefense ;
		public int totalAttrHit ;
		public int totalAttrDodge ;
		public int totalAttrPenetration ;
		public int totalAttrPenetrationDef ;
		public int totalAttrRevover ;
		public int totalAttrTreat ;
		public int totalAttrVampire ;
		public int totalAttrCritical ;
		public int totalAttrAttackSpeed ;
		public int totalAttrMoveSpeed ;
		public int totalAttrSkillCd ;
		public int totalAttrDamageAdd ;
		public int totalAttrDamageReduce ;
		public int totalPartialAttrHp ;
		public int totalPartialAttrAttack ;
		public int totalPartialAttrDefense ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			totalAttrHp = (int)((player.getMemberValue(as3Object, "totalAttrHp"  )));
			totalAttrAttack = (int)((player.getMemberValue(as3Object, "totalAttrAttack"  )));
			totalAttrDefense = (int)((player.getMemberValue(as3Object, "totalAttrDefense"  )));
			totalAttrCrit = (int)((player.getMemberValue(as3Object, "totalAttrCrit"  )));
			totalAttrCritDefense = (int)((player.getMemberValue(as3Object, "totalAttrCritDefense"  )));
			totalAttrHit = (int)((player.getMemberValue(as3Object, "totalAttrHit"  )));
			totalAttrDodge = (int)((player.getMemberValue(as3Object, "totalAttrDodge"  )));
			totalAttrPenetration = (int)((player.getMemberValue(as3Object, "totalAttrPenetration"  )));
			totalAttrPenetrationDef = (int)((player.getMemberValue(as3Object, "totalAttrPenetrationDef"  )));
			totalAttrRevover = (int)((player.getMemberValue(as3Object, "totalAttrRevover"  )));
			totalAttrTreat = (int)((player.getMemberValue(as3Object, "totalAttrTreat"  )));
			totalAttrVampire = (int)((player.getMemberValue(as3Object, "totalAttrVampire"  )));
			totalAttrCritical = (int)((player.getMemberValue(as3Object, "totalAttrCritical"  )));
			totalAttrAttackSpeed = (int)((player.getMemberValue(as3Object, "totalAttrAttackSpeed"  )));
			totalAttrMoveSpeed = (int)((player.getMemberValue(as3Object, "totalAttrMoveSpeed"  )));
			totalAttrSkillCd = (int)((player.getMemberValue(as3Object, "totalAttrSkillCd"  )));
			totalAttrDamageAdd = (int)((player.getMemberValue(as3Object, "totalAttrDamageAdd"  )));
			totalAttrDamageReduce = (int)((player.getMemberValue(as3Object, "totalAttrDamageReduce"  )));
			totalPartialAttrHp = (int)((player.getMemberValue(as3Object, "totalPartialAttrHp"  )));
			totalPartialAttrAttack = (int)((player.getMemberValue(as3Object, "totalPartialAttrAttack"  )));
			totalPartialAttrDefense = (int)((player.getMemberValue(as3Object, "totalPartialAttrDefense"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "totalAttrHp", (totalAttrHp) );
			player.setMemberValue(as3Object, "totalAttrAttack", (totalAttrAttack) );
			player.setMemberValue(as3Object, "totalAttrDefense", (totalAttrDefense) );
			player.setMemberValue(as3Object, "totalAttrCrit", (totalAttrCrit) );
			player.setMemberValue(as3Object, "totalAttrCritDefense", (totalAttrCritDefense) );
			player.setMemberValue(as3Object, "totalAttrHit", (totalAttrHit) );
			player.setMemberValue(as3Object, "totalAttrDodge", (totalAttrDodge) );
			player.setMemberValue(as3Object, "totalAttrPenetration", (totalAttrPenetration) );
			player.setMemberValue(as3Object, "totalAttrPenetrationDef", (totalAttrPenetrationDef) );
			player.setMemberValue(as3Object, "totalAttrRevover", (totalAttrRevover) );
			player.setMemberValue(as3Object, "totalAttrTreat", (totalAttrTreat) );
			player.setMemberValue(as3Object, "totalAttrVampire", (totalAttrVampire) );
			player.setMemberValue(as3Object, "totalAttrCritical", (totalAttrCritical) );
			player.setMemberValue(as3Object, "totalAttrAttackSpeed", (totalAttrAttackSpeed) );
			player.setMemberValue(as3Object, "totalAttrMoveSpeed", (totalAttrMoveSpeed) );
			player.setMemberValue(as3Object, "totalAttrSkillCd", (totalAttrSkillCd) );
			player.setMemberValue(as3Object, "totalAttrDamageAdd", (totalAttrDamageAdd) );
			player.setMemberValue(as3Object, "totalAttrDamageReduce", (totalAttrDamageReduce) );
			player.setMemberValue(as3Object, "totalPartialAttrHp", (totalPartialAttrHp) );
			player.setMemberValue(as3Object, "totalPartialAttrAttack", (totalPartialAttrAttack) );
			player.setMemberValue(as3Object, "totalPartialAttrDefense", (totalPartialAttrDefense) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public enum base_msg_id
	{
		 name_check_id = 1,
		 name_check_ack_id = 2,
		 change_name_check_id = 3,
		 change_name_check_ack_id = 4,
		 player_leave_game_ntf_id = 5,
		 common_protocol_id = 2000,
		 common_protocol_forwarded_req_id = 2100,
		 common_protocol_forwarded_ack_id = 2101,

	}
}

namespace SProtoSpace
{
	public class beat_heart_ntf : AS3Proto.Message
	{
		public beat_heart_ntf()
		{
			createAs3Object("SProtoSpace.beat_heart_ntf");
		}

		private beat_heart_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static beat_heart_ntf Create(object rtObject)
		{
			return new beat_heart_ntf((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class change_name_ack : AS3Proto.Message
	{
		public change_name_ack()
		{
			createAs3Object("SProtoSpace.change_name_ack");
		}

		private change_name_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static change_name_ack Create(object rtObject)
		{
			return new change_name_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearName(){ player.invokeMethod(as3Object, "clearName");}
		public bool hasName{get { return (bool)((player.getMemberValue(as3Object, "hasName"))); }}
		public string name{get { return (string)((player.getMemberValue(as3Object, "name"))); }set { player.setMemberValue(as3Object, "name", (value)); }}
		public int ret ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "ret", (ret) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class change_name_check : AS3Proto.Message
	{
		public change_name_check()
		{
			createAs3Object("SProtoSpace.change_name_check");
		}

		private change_name_check(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static change_name_check Create(object rtObject)
		{
			return new change_name_check((ASBinCode.rtData.rtObject)rtObject);
		}


		public string newName ;
		public string oldName ;
		public uint clientid ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			newName = (string)((player.getMemberValue(as3Object, "newName"  )));
			oldName = (string)((player.getMemberValue(as3Object, "oldName"  )));
			clientid = (uint)((player.getMemberValue(as3Object, "clientid"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "newName", (newName) );
			player.setMemberValue(as3Object, "oldName", (oldName) );
			player.setMemberValue(as3Object, "clientid", (clientid) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class change_name_check_ack : AS3Proto.Message
	{
		public change_name_check_ack()
		{
			createAs3Object("SProtoSpace.change_name_check_ack");
		}

		private change_name_check_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static change_name_check_ack Create(object rtObject)
		{
			return new change_name_check_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public string newName ;
		public string oldName ;
		public uint clientid ;
		public int ret ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			newName = (string)((player.getMemberValue(as3Object, "newName"  )));
			oldName = (string)((player.getMemberValue(as3Object, "oldName"  )));
			clientid = (uint)((player.getMemberValue(as3Object, "clientid"  )));
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "newName", (newName) );
			player.setMemberValue(as3Object, "oldName", (oldName) );
			player.setMemberValue(as3Object, "clientid", (clientid) );
			player.setMemberValue(as3Object, "ret", (ret) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class common_protocol_forwarded_ack : AS3Proto.Message
	{
		public common_protocol_forwarded_ack()
		{
			createAs3Object("SProtoSpace.common_protocol_forwarded_ack");
		}

		private common_protocol_forwarded_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static common_protocol_forwarded_ack Create(object rtObject)
		{
			return new common_protocol_forwarded_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public byte[] packetData ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			packetData = (byte[])(ConvertByteArrayToBytes(player.getMemberValue(as3Object, "packetData"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "packetData", ConvertBytesToByteArray(packetData) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class common_protocol_forwarded_req : AS3Proto.Message
	{
		public common_protocol_forwarded_req()
		{
			createAs3Object("SProtoSpace.common_protocol_forwarded_req");
		}

		private common_protocol_forwarded_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static common_protocol_forwarded_req Create(object rtObject)
		{
			return new common_protocol_forwarded_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public byte[] packetData ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			packetData = (byte[])(ConvertByteArrayToBytes(player.getMemberValue(as3Object, "packetData"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "packetData", ConvertBytesToByteArray(packetData) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class create_role_of_game : AS3Proto.Message
	{
		public create_role_of_game()
		{
			createAs3Object("SProtoSpace.create_role_of_game");
		}

		private create_role_of_game(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static create_role_of_game Create(object rtObject)
		{
			return new create_role_of_game((ASBinCode.rtData.rtObject)rtObject);
		}


		public string account ;
		public string playername ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			playername = (string)((player.getMemberValue(as3Object, "playername"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "account", (account) );
			player.setMemberValue(as3Object, "playername", (playername) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class create_role_of_game_ack : AS3Proto.Message
	{
		public create_role_of_game_ack()
		{
			createAs3Object("SProtoSpace.create_role_of_game_ack");
		}

		private create_role_of_game_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static create_role_of_game_ack Create(object rtObject)
		{
			return new create_role_of_game_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public int createRet ;
		public void clearAccount(){ player.invokeMethod(as3Object, "clearAccount");}
		public bool hasAccount{get { return (bool)((player.getMemberValue(as3Object, "hasAccount"))); }}
		public string account{get { return (string)((player.getMemberValue(as3Object, "account"))); }set { player.setMemberValue(as3Object, "account", (value)); }}
		public string playername ;
		public void clearPlayerid(){ player.invokeMethod(as3Object, "clearPlayerid");}
		public bool hasPlayerid{get { return (bool)((player.getMemberValue(as3Object, "hasPlayerid"))); }}
		public System.UInt64 playerid{get { return (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "playerid"))); }set { player.setMemberValue(as3Object, "playerid", ConvertULongToObj(value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			createRet = (int)((player.getMemberValue(as3Object, "createRet"  )));
			playername = (string)((player.getMemberValue(as3Object, "playername"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "createRet", (createRet) );
			player.setMemberValue(as3Object, "playername", (playername) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class db_role_base_info : AS3Proto.Message
	{
		public db_role_base_info()
		{
			createAs3Object("SProtoSpace.db_role_base_info");
		}

		private db_role_base_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static db_role_base_info Create(object rtObject)
		{
			return new db_role_base_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public int level ;
		public int gameid ;
		public string account ;
		public uint vp ;
		public uint vpUpdateTime ;
		public uint exp ;
		public void clearCoin(){ player.invokeMethod(as3Object, "clearCoin");}
		public bool hasCoin{get { return (bool)((player.getMemberValue(as3Object, "hasCoin"))); }}
		public uint coin{get { return (uint)((player.getMemberValue(as3Object, "coin"))); }set { player.setMemberValue(as3Object, "coin", (value)); }}
		public void clearDiamond(){ player.invokeMethod(as3Object, "clearDiamond");}
		public bool hasDiamond{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond"))); }}
		public uint diamond{get { return (uint)((player.getMemberValue(as3Object, "diamond"))); }set { player.setMemberValue(as3Object, "diamond", (value)); }}
		public void clearViplevel(){ player.invokeMethod(as3Object, "clearViplevel");}
		public bool hasViplevel{get { return (bool)((player.getMemberValue(as3Object, "hasViplevel"))); }}
		public int viplevel{get { return (int)((player.getMemberValue(as3Object, "viplevel"))); }set { player.setMemberValue(as3Object, "viplevel", (value)); }}
		public void clearVipexp(){ player.invokeMethod(as3Object, "clearVipexp");}
		public bool hasVipexp{get { return (bool)((player.getMemberValue(as3Object, "hasVipexp"))); }}
		public int vipexp{get { return (int)((player.getMemberValue(as3Object, "vipexp"))); }set { player.setMemberValue(as3Object, "vipexp", (value)); }}
		public void clearLastleavetime(){ player.invokeMethod(as3Object, "clearLastleavetime");}
		public bool hasLastleavetime{get { return (bool)((player.getMemberValue(as3Object, "hasLastleavetime"))); }}
		public uint lastleavetime{get { return (uint)((player.getMemberValue(as3Object, "lastleavetime"))); }set { player.setMemberValue(as3Object, "lastleavetime", (value)); }}
		public void clearDecomposeCoin(){ player.invokeMethod(as3Object, "clearDecomposeCoin");}
		public bool hasDecomposeCoin{get { return (bool)((player.getMemberValue(as3Object, "hasDecomposeCoin"))); }}
		public int decomposeCoin{get { return (int)((player.getMemberValue(as3Object, "decomposeCoin"))); }set { player.setMemberValue(as3Object, "decomposeCoin", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			level = (int)((player.getMemberValue(as3Object, "level"  )));
			gameid = (int)((player.getMemberValue(as3Object, "gameid"  )));
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			vp = (uint)((player.getMemberValue(as3Object, "vp"  )));
			vpUpdateTime = (uint)((player.getMemberValue(as3Object, "vpUpdateTime"  )));
			exp = (uint)((player.getMemberValue(as3Object, "exp"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "level", (level) );
			player.setMemberValue(as3Object, "gameid", (gameid) );
			player.setMemberValue(as3Object, "account", (account) );
			player.setMemberValue(as3Object, "vp", (vp) );
			player.setMemberValue(as3Object, "vpUpdateTime", (vpUpdateTime) );
			player.setMemberValue(as3Object, "exp", (exp) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class dungeon_team_player : AS3Proto.Message
	{
		public dungeon_team_player()
		{
			createAs3Object("SProtoSpace.dungeon_team_player");
		}

		private dungeon_team_player(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static dungeon_team_player Create(object rtObject)
		{
			return new dungeon_team_player((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 llId ;
		public void clearName(){ player.invokeMethod(as3Object, "clearName");}
		public bool hasName{get { return (bool)((player.getMemberValue(as3Object, "hasName"))); }}
		public string name{get { return (string)((player.getMemberValue(as3Object, "name"))); }set { player.setMemberValue(as3Object, "name", (value)); }}
		public void clearState(){ player.invokeMethod(as3Object, "clearState");}
		public bool hasState{get { return (bool)((player.getMemberValue(as3Object, "hasState"))); }}
		public int state{get { return (int)((player.getMemberValue(as3Object, "state"))); }set { player.setMemberValue(as3Object, "state", (value)); }}
		public void clearHeroId(){ player.invokeMethod(as3Object, "clearHeroId");}
		public bool hasHeroId{get { return (bool)((player.getMemberValue(as3Object, "hasHeroId"))); }}
		public int heroId{get { return (int)((player.getMemberValue(as3Object, "heroId"))); }set { player.setMemberValue(as3Object, "heroId", (value)); }}
		public void clearHeroLevel(){ player.invokeMethod(as3Object, "clearHeroLevel");}
		public bool hasHeroLevel{get { return (bool)((player.getMemberValue(as3Object, "hasHeroLevel"))); }}
		public int heroLevel{get { return (int)((player.getMemberValue(as3Object, "heroLevel"))); }set { player.setMemberValue(as3Object, "heroLevel", (value)); }}
		public void clearHeroStar(){ player.invokeMethod(as3Object, "clearHeroStar");}
		public bool hasHeroStar{get { return (bool)((player.getMemberValue(as3Object, "hasHeroStar"))); }}
		public int heroStar{get { return (int)((player.getMemberValue(as3Object, "heroStar"))); }set { player.setMemberValue(as3Object, "heroStar", (value)); }}
		public void clearHeroQuality(){ player.invokeMethod(as3Object, "clearHeroQuality");}
		public bool hasHeroQuality{get { return (bool)((player.getMemberValue(as3Object, "hasHeroQuality"))); }}
		public int heroQuality{get { return (int)((player.getMemberValue(as3Object, "heroQuality"))); }set { player.setMemberValue(as3Object, "heroQuality", (value)); }}
		public void clearBattleAbility(){ player.invokeMethod(as3Object, "clearBattleAbility");}
		public bool hasBattleAbility{get { return (bool)((player.getMemberValue(as3Object, "hasBattleAbility"))); }}
		public uint battleAbility{get { return (uint)((player.getMemberValue(as3Object, "battleAbility"))); }set { player.setMemberValue(as3Object, "battleAbility", (value)); }}
		public void clearPos(){ player.invokeMethod(as3Object, "clearPos");}
		public bool hasPos{get { return (bool)((player.getMemberValue(as3Object, "hasPos"))); }}
		public int pos{get { return (int)((player.getMemberValue(as3Object, "pos"))); }set { player.setMemberValue(as3Object, "pos", (value)); }}
		public void clearServerId(){ player.invokeMethod(as3Object, "clearServerId");}
		public bool hasServerId{get { return (bool)((player.getMemberValue(as3Object, "hasServerId"))); }}
		public int serverId{get { return (int)((player.getMemberValue(as3Object, "serverId"))); }set { player.setMemberValue(as3Object, "serverId", (value)); }}
		public void clearIsRobot(){ player.invokeMethod(as3Object, "clearIsRobot");}
		public bool hasIsRobot{get { return (bool)((player.getMemberValue(as3Object, "hasIsRobot"))); }}
		public bool isRobot{get { return (bool)((player.getMemberValue(as3Object, "isRobot"))); }set { player.setMemberValue(as3Object, "isRobot", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			llId = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "llId"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "llId", ConvertULongToObj(llId) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public enum EAreaState
	{
		 AREA_STATE_GOOD = 1,
		 AREA_STATE_BUSY = 2,
		 AREA_STATE_CROWD = 3,
		 AREA_STATE_MAINTENANCE = 4,

	}
}

namespace SProtoSpace
{
	public enum EAuthType
	{
		 AUTH_SELF = 0,
		 AUTH_XIAOMI = 1,

	}
}

namespace SProtoSpace
{
	public enum eCommonDefine
	{
		 max_role_hero_size = 128,
		 max_role_bag_size = 2048,
		 max_hero_symbol_size = 6,
		 max_role_skill_size = 12,
		 max_role_friends_size = 50,
		 max_hero_model_size = 3,
		 max_daily_activity_size = 32,
		 max_team_heros_size = 1,
		 max_rs_reward_size = 10,
		 max_largemap_box_size = 256,
		 max_sevenday_activity_size = 700,

	}
}

namespace SProtoSpace
{
	public enum eCreateResult
	{
		 create_result_ok = 0,
		 create_result_fail = 1,
		 create_result_duplicate = 2,
		 create_result_sensitive_word = 3,
		 create_result_state_error = 4,

	}
}

namespace SProtoSpace
{
	public enum ECrossServerType
	{
		 BACK_NORMAL_SERVER = 0,
		 CROSS_LOCAL_SERVER = 1,
		 CROSS_GLOBAL_SERVER = 2,

	}
}

namespace SProtoSpace
{
	public enum eEnterGameAck
	{
		 ENTER_GAME_SUCC = 0,
		 ENTER_GAME_CAN_NOT_FIND_ROLE = 1,
		 ENTER_GAME_STATE_ERROR = 2,
		 ENTER_GAME_CAN_NOT_FIND_GAME = 3,
		 ENTER_GAME_IN_BATTLE = 4,

	}
}

namespace SProtoSpace
{
	public enum eHeroEquipPos
	{
		 EQUIP_HAND = 0,
		 EQUIP_HEAD = 1,
		 EQUIP_UPBODY = 2,
		 EQUIP_ARM = 3,
		 EQUIP_WAIST = 4,
		 EQUIP_SHOULDER = 5,
		 EQUIP_FEET = 6,
		 EQUIP_LEG = 7,
		 EQUIP_SIZE = 8,

	}
}

namespace SProtoSpace
{
	public enum eKickoutReason
	{
		 KickoutReason_login = 1,

	}
}

namespace SProtoSpace
{
	public enum eMsgId1
	{
		 group_player_info_id = 21,
		 role_connect_in_req_id = 22,
		 create_role_of_game_id = 23,
		 create_role_of_game_ack_id = 24,
		 enter_game_req_id = 25,
		 reconnect_to_check_info_req_id = 26,
		 reconnect_to_check_info_ack_id = 27,
		 enter_game_ack_id = 29,
		 player_leave_game_req_id = 31,
		 rand_names_req_id = 32,
		 rand_names_ack_id = 33,
		 beat_heart_ntf_id = 737,
		 gate_test_req_id = 820,
		 gate_test_ack_id = 821,
		 sync_time_ntf_id = 130,
		 account_repeated_tick_ntf_id = 134,
		 change_name_req_id = 141,
		 change_name_ack_id = 142,
		 gate_need_queued_ntf_id = 4930,
		 gate_end_queued_ntf_id = 4931,
		 gate_queued_state_req_id = 4932,
		 gate_queued_state_ack_id = 4933,
		 gate_cancel_queue_req_id = 4934,
		 gate_cancel_queue_ack_id = 4935,

	}
}

namespace SProtoSpace
{
	public class enter_game_ack : AS3Proto.Message
	{
		public enter_game_ack()
		{
			createAs3Object("SProtoSpace.enter_game_ack");
		}

		private enter_game_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static enter_game_ack Create(object rtObject)
		{
			return new enter_game_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public int ret ;
		public void clearBase(){ player.invokeMethod(as3Object, "clearBase");}
		public bool hasBase{get { return (bool)((player.getMemberValue(as3Object, "hasBase"))); }}
		private SProtoSpace.db_role_base_info ___base_; private bool ___base_flag___;
		public SProtoSpace.db_role_base_info base_
		{
			get
			{
				if (___base_ == null && !___base_flag___)
				{
					___base_flag___ = true;
					var obj = player.getMemberValue(as3Object, "base");
					if(obj !=null)
						___base_ = SProtoSpace.db_role_base_info.Create(obj);
				}

				return ___base_;
			}
			set
			{
				___base_ = value;
				if (value != null)
				{
					player.setMemberValue(as3Object, "base", LoadBindObject(value));
				}
				else
				{
					player.setMemberValue(as3Object, "base", null);
				}
			}
		}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "ret", (ret) );
				{
					var value = ___base_;
					if (value != null)
					{
						player.setMemberValue(as3Object, "base", LoadBindObjectAndWriteField(value));
					}
					else
					{
						player.setMemberValue(as3Object, "base", null);
					}
				}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class enter_game_req : AS3Proto.Message
	{
		public enter_game_req()
		{
			createAs3Object("SProtoSpace.enter_game_req");
		}

		private enter_game_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static enter_game_req Create(object rtObject)
		{
			return new enter_game_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 playerid ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			playerid = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "playerid"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "playerid", ConvertULongToObj(playerid) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class friend_base_info : AS3Proto.Message
	{
		public friend_base_info()
		{
			createAs3Object("SProtoSpace.friend_base_info");
		}

		private friend_base_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static friend_base_info Create(object rtObject)
		{
			return new friend_base_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearPlayerId(){ player.invokeMethod(as3Object, "clearPlayerId");}
		public bool hasPlayerId{get { return (bool)((player.getMemberValue(as3Object, "hasPlayerId"))); }}
		public System.UInt64 playerId{get { return (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "playerId"))); }set { player.setMemberValue(as3Object, "playerId", ConvertULongToObj(value)); }}
		public void clearPlayerName(){ player.invokeMethod(as3Object, "clearPlayerName");}
		public bool hasPlayerName{get { return (bool)((player.getMemberValue(as3Object, "hasPlayerName"))); }}
		public string playerName{get { return (string)((player.getMemberValue(as3Object, "playerName"))); }set { player.setMemberValue(as3Object, "playerName", (value)); }}
		public void clearPlayerLv(){ player.invokeMethod(as3Object, "clearPlayerLv");}
		public bool hasPlayerLv{get { return (bool)((player.getMemberValue(as3Object, "hasPlayerLv"))); }}
		public int playerLv{get { return (int)((player.getMemberValue(as3Object, "playerLv"))); }set { player.setMemberValue(as3Object, "playerLv", (value)); }}
		public void clearTemplateId(){ player.invokeMethod(as3Object, "clearTemplateId");}
		public bool hasTemplateId{get { return (bool)((player.getMemberValue(as3Object, "hasTemplateId"))); }}
		public int templateId{get { return (int)((player.getMemberValue(as3Object, "templateId"))); }set { player.setMemberValue(as3Object, "templateId", (value)); }}
		public void clearVipLv(){ player.invokeMethod(as3Object, "clearVipLv");}
		public bool hasVipLv{get { return (bool)((player.getMemberValue(as3Object, "hasVipLv"))); }}
		public int vipLv{get { return (int)((player.getMemberValue(as3Object, "vipLv"))); }set { player.setMemberValue(as3Object, "vipLv", (value)); }}
		public void clearSocietyName(){ player.invokeMethod(as3Object, "clearSocietyName");}
		public bool hasSocietyName{get { return (bool)((player.getMemberValue(as3Object, "hasSocietyName"))); }}
		public string societyName{get { return (string)((player.getMemberValue(as3Object, "societyName"))); }set { player.setMemberValue(as3Object, "societyName", (value)); }}
		public void clearTotalAbility(){ player.invokeMethod(as3Object, "clearTotalAbility");}
		public bool hasTotalAbility{get { return (bool)((player.getMemberValue(as3Object, "hasTotalAbility"))); }}
		public int totalAbility{get { return (int)((player.getMemberValue(as3Object, "totalAbility"))); }set { player.setMemberValue(as3Object, "totalAbility", (value)); }}
		public void clearIsNewMsg(){ player.invokeMethod(as3Object, "clearIsNewMsg");}
		public bool hasIsNewMsg{get { return (bool)((player.getMemberValue(as3Object, "hasIsNewMsg"))); }}
		public bool isNewMsg{get { return (bool)((player.getMemberValue(as3Object, "isNewMsg"))); }set { player.setMemberValue(as3Object, "isNewMsg", (value)); }}
		public void clearIsFriend(){ player.invokeMethod(as3Object, "clearIsFriend");}
		public bool hasIsFriend{get { return (bool)((player.getMemberValue(as3Object, "hasIsFriend"))); }}
		public bool isFriend{get { return (bool)((player.getMemberValue(as3Object, "isFriend"))); }set { player.setMemberValue(as3Object, "isFriend", (value)); }}
		public void clearOfflineTime(){ player.invokeMethod(as3Object, "clearOfflineTime");}
		public bool hasOfflineTime{get { return (bool)((player.getMemberValue(as3Object, "hasOfflineTime"))); }}
		public uint offlineTime{get { return (uint)((player.getMemberValue(as3Object, "offlineTime"))); }set { player.setMemberValue(as3Object, "offlineTime", (value)); }}
		public void clearIsCanGive(){ player.invokeMethod(as3Object, "clearIsCanGive");}
		public bool hasIsCanGive{get { return (bool)((player.getMemberValue(as3Object, "hasIsCanGive"))); }}
		public bool isCanGive{get { return (bool)((player.getMemberValue(as3Object, "isCanGive"))); }set { player.setMemberValue(as3Object, "isCanGive", (value)); }}
		public void clearDataType(){ player.invokeMethod(as3Object, "clearDataType");}
		public bool hasDataType{get { return (bool)((player.getMemberValue(as3Object, "hasDataType"))); }}
		public uint dataType{get { return (uint)((player.getMemberValue(as3Object, "dataType"))); }set { player.setMemberValue(as3Object, "dataType", (value)); }}
		public void clearCaravanId(){ player.invokeMethod(as3Object, "clearCaravanId");}
		public bool hasCaravanId{get { return (bool)((player.getMemberValue(as3Object, "hasCaravanId"))); }}
		public int caravanId{get { return (int)((player.getMemberValue(as3Object, "caravanId"))); }set { player.setMemberValue(as3Object, "caravanId", (value)); }}





	}
}

namespace SProtoSpace
{
	public class gate_cancel_queue_ack : AS3Proto.Message
	{
		public gate_cancel_queue_ack()
		{
			createAs3Object("SProtoSpace.gate_cancel_queue_ack");
		}

		private gate_cancel_queue_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_cancel_queue_ack Create(object rtObject)
		{
			return new gate_cancel_queue_ack((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class gate_cancel_queue_req : AS3Proto.Message
	{
		public gate_cancel_queue_req()
		{
			createAs3Object("SProtoSpace.gate_cancel_queue_req");
		}

		private gate_cancel_queue_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_cancel_queue_req Create(object rtObject)
		{
			return new gate_cancel_queue_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class gate_end_queued_ntf : AS3Proto.Message
	{
		public gate_end_queued_ntf()
		{
			createAs3Object("SProtoSpace.gate_end_queued_ntf");
		}

		private gate_end_queued_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_end_queued_ntf Create(object rtObject)
		{
			return new gate_end_queued_ntf((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class gate_need_queued_ntf : AS3Proto.Message
	{
		public gate_need_queued_ntf()
		{
			createAs3Object("SProtoSpace.gate_need_queued_ntf");
		}

		private gate_need_queued_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_need_queued_ntf Create(object rtObject)
		{
			return new gate_need_queued_ntf((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint pos ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			pos = (uint)((player.getMemberValue(as3Object, "pos"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "pos", (pos) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class gate_net_info : AS3Proto.Message
	{
		public gate_net_info()
		{
			createAs3Object("SProtoSpace.gate_net_info");
		}

		private gate_net_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_net_info Create(object rtObject)
		{
			return new gate_net_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint id ;
		public string ip ;
		public int port ;
		public string groupName ;
		public bool __new ;
		public int state ;
		public uint groupindex ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			id = (uint)((player.getMemberValue(as3Object, "id"  )));
			ip = (string)((player.getMemberValue(as3Object, "ip"  )));
			port = (int)((player.getMemberValue(as3Object, "port"  )));
			groupName = (string)((player.getMemberValue(as3Object, "groupName"  )));
			__new = (bool)((player.getMemberValue(as3Object, "__new"  )));
			state = (int)((player.getMemberValue(as3Object, "state"  )));
			groupindex = (uint)((player.getMemberValue(as3Object, "groupindex"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "id", (id) );
			player.setMemberValue(as3Object, "ip", (ip) );
			player.setMemberValue(as3Object, "port", (port) );
			player.setMemberValue(as3Object, "groupName", (groupName) );
			player.setMemberValue(as3Object, "__new", (__new) );
			player.setMemberValue(as3Object, "state", (state) );
			player.setMemberValue(as3Object, "groupindex", (groupindex) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class gate_queued_state_ack : AS3Proto.Message
	{
		public gate_queued_state_ack()
		{
			createAs3Object("SProtoSpace.gate_queued_state_ack");
		}

		private gate_queued_state_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_queued_state_ack Create(object rtObject)
		{
			return new gate_queued_state_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint pos ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			pos = (uint)((player.getMemberValue(as3Object, "pos"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "pos", (pos) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class gate_queued_state_req : AS3Proto.Message
	{
		public gate_queued_state_req()
		{
			createAs3Object("SProtoSpace.gate_queued_state_req");
		}

		private gate_queued_state_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_queued_state_req Create(object rtObject)
		{
			return new gate_queued_state_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class gate_test_ack : AS3Proto.Message
	{
		public gate_test_ack()
		{
			createAs3Object("SProtoSpace.gate_test_ack");
		}

		private gate_test_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_test_ack Create(object rtObject)
		{
			return new gate_test_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearRet(){ player.invokeMethod(as3Object, "clearRet");}
		public bool hasRet{get { return (bool)((player.getMemberValue(as3Object, "hasRet"))); }}
		public int ret{get { return (int)((player.getMemberValue(as3Object, "ret"))); }set { player.setMemberValue(as3Object, "ret", (value)); }}
		public void clearSendTime(){ player.invokeMethod(as3Object, "clearSendTime");}
		public bool hasSendTime{get { return (bool)((player.getMemberValue(as3Object, "hasSendTime"))); }}
		public System.Int64 sendTime{get { return (System.Int64)(ConvertObjToLong(player.getMemberValue(as3Object, "sendTime"))); }set { player.setMemberValue(as3Object, "sendTime", ConvertLongToObj(value)); }}





	}
}

namespace SProtoSpace
{
	public class gate_test_req : AS3Proto.Message
	{
		public gate_test_req()
		{
			createAs3Object("SProtoSpace.gate_test_req");
		}

		private gate_test_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static gate_test_req Create(object rtObject)
		{
			return new gate_test_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearSendTime(){ player.invokeMethod(as3Object, "clearSendTime");}
		public bool hasSendTime{get { return (bool)((player.getMemberValue(as3Object, "hasSendTime"))); }}
		public System.Int64 sendTime{get { return (System.Int64)(ConvertObjToLong(player.getMemberValue(as3Object, "sendTime"))); }set { player.setMemberValue(as3Object, "sendTime", ConvertLongToObj(value)); }}





	}
}

namespace SProtoSpace
{
	public class group_area_info : AS3Proto.Message
	{
		public group_area_info()
		{
			createAs3Object("SProtoSpace.group_area_info");
		}

		private group_area_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static group_area_info Create(object rtObject)
		{
			return new group_area_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.Collections.Generic.List<uint> groupids ;
		public string areaGroupName ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			{
				groupids = new System.Collections.Generic.List<uint>();
				uint len = (uint)player.getMemberValue(as3Object, "groupids.length");
				for (int i = 0; i < len; i++)
				{
					uint v = default(uint);
					v = (uint)((player.getMemberValue(as3Object, "groupids" ,i )));

					groupids.Add(v);
				}
			}
			areaGroupName = (string)((player.getMemberValue(as3Object, "areaGroupName"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			{
				player.setMemberValue(as3Object, "groupids.length", groupids.Count);
				for (int i = 0; i < groupids.Count; i++)
				{
					var v = groupids[i];
					player.setMemberValue(as3Object, "groupids", (v),i );
					
				}
			}
			player.setMemberValue(as3Object, "areaGroupName", (areaGroupName) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class group_hero_info : AS3Proto.Message
	{
		public group_hero_info()
		{
			createAs3Object("SProtoSpace.group_hero_info");
		}

		private group_hero_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static group_hero_info Create(object rtObject)
		{
			return new group_hero_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint groupid ;
		public uint heroid ;
		public uint lev ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			groupid = (uint)((player.getMemberValue(as3Object, "groupid"  )));
			heroid = (uint)((player.getMemberValue(as3Object, "heroid"  )));
			lev = (uint)((player.getMemberValue(as3Object, "lev"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "groupid", (groupid) );
			player.setMemberValue(as3Object, "heroid", (heroid) );
			player.setMemberValue(as3Object, "lev", (lev) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class group_player_info : AS3Proto.Message
	{
		public group_player_info()
		{
			createAs3Object("SProtoSpace.group_player_info");
		}

		private group_player_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static group_player_info Create(object rtObject)
		{
			return new group_player_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 playerid ;
		public void clearPlayername(){ player.invokeMethod(as3Object, "clearPlayername");}
		public bool hasPlayername{get { return (bool)((player.getMemberValue(as3Object, "hasPlayername"))); }}
		public string playername{get { return (string)((player.getMemberValue(as3Object, "playername"))); }set { player.setMemberValue(as3Object, "playername", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			playerid = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "playerid"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "playerid", ConvertULongToObj(playerid) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class hero_equip_info : AS3Proto.Message
	{
		public hero_equip_info()
		{
			createAs3Object("SProtoSpace.hero_equip_info");
		}

		private hero_equip_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static hero_equip_info Create(object rtObject)
		{
			return new hero_equip_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public int equipPos ;
		public uint itemIndex ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			equipPos = (int)((player.getMemberValue(as3Object, "equipPos"  )));
			itemIndex = (uint)((player.getMemberValue(as3Object, "itemIndex"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "equipPos", (equipPos) );
			player.setMemberValue(as3Object, "itemIndex", (itemIndex) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class hero_skill_info : AS3Proto.Message
	{
		public hero_skill_info()
		{
			createAs3Object("SProtoSpace.hero_skill_info");
		}

		private hero_skill_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static hero_skill_info Create(object rtObject)
		{
			return new hero_skill_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint id ;
		public void clearLevel(){ player.invokeMethod(as3Object, "clearLevel");}
		public bool hasLevel{get { return (bool)((player.getMemberValue(as3Object, "hasLevel"))); }}
		public int level{get { return (int)((player.getMemberValue(as3Object, "level"))); }set { player.setMemberValue(as3Object, "level", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			id = (uint)((player.getMemberValue(as3Object, "id"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "id", (id) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class hero_symbol_info : AS3Proto.Message
	{
		public hero_symbol_info()
		{
			createAs3Object("SProtoSpace.hero_symbol_info");
		}

		private hero_symbol_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static hero_symbol_info Create(object rtObject)
		{
			return new hero_symbol_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public int symbolPos ;
		public uint itemIndex ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			symbolPos = (int)((player.getMemberValue(as3Object, "symbolPos"  )));
			itemIndex = (uint)((player.getMemberValue(as3Object, "itemIndex"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "symbolPos", (symbolPos) );
			player.setMemberValue(as3Object, "itemIndex", (itemIndex) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class iteminfo : AS3Proto.Message
	{
		public iteminfo()
		{
			createAs3Object("SProtoSpace.iteminfo");
		}

		private iteminfo(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static iteminfo Create(object rtObject)
		{
			return new iteminfo((ASBinCode.rtData.rtObject)rtObject);
		}


		public int type ;
		public uint id ;
		public int num ;
		public void clearResolveHeroId(){ player.invokeMethod(as3Object, "clearResolveHeroId");}
		public bool hasResolveHeroId{get { return (bool)((player.getMemberValue(as3Object, "hasResolveHeroId"))); }}
		public int resolveHeroId{get { return (int)((player.getMemberValue(as3Object, "resolveHeroId"))); }set { player.setMemberValue(as3Object, "resolveHeroId", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			type = (int)((player.getMemberValue(as3Object, "type"  )));
			id = (uint)((player.getMemberValue(as3Object, "id"  )));
			num = (int)((player.getMemberValue(as3Object, "num"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "type", (type) );
			player.setMemberValue(as3Object, "id", (id) );
			player.setMemberValue(as3Object, "num", (num) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class login_ack : AS3Proto.Message
	{
		public login_ack()
		{
			createAs3Object("SProtoSpace.login_ack");
		}

		private login_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_ack Create(object rtObject)
		{
			return new login_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public int ret ;
		public System.Collections.Generic.List<SProtoSpace.EAuthType> authtypelist ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			{
				authtypelist = new System.Collections.Generic.List<SProtoSpace.EAuthType>();
				uint len = (uint)player.getMemberValue(as3Object, "authtypelist.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.EAuthType v = default(SProtoSpace.EAuthType);
					v = (SProtoSpace.EAuthType)((player.getMemberValue(as3Object, "authtypelist" ,i )));

					authtypelist.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "ret", (ret) );
			{
				player.setMemberValue(as3Object, "authtypelist.length", authtypelist.Count);
				for (int i = 0; i < authtypelist.Count; i++)
				{
					var v = authtypelist[i];
					player.setMemberValue(as3Object, "authtypelist", (int)(v),i );
					
				}
			}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public enum login_ack_error
	{
		 CHECK_ACCOUNT_UNKNOW = -3,
		 CHECK_ACCOUNT_INVALID = -2,
		 CHECK_PASSWORD_ERROR = -1,
		 CHECK_PASSWORD_OK = 0,
		 CHECK_PASSWORD_NEW_USER_OK = 1,
		 CHECK_ALL_OK = 2,

	}
}

namespace SProtoSpace
{
	public class login_cancel_queue_ack : AS3Proto.Message
	{
		public login_cancel_queue_ack()
		{
			createAs3Object("SProtoSpace.login_cancel_queue_ack");
		}

		private login_cancel_queue_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_cancel_queue_ack Create(object rtObject)
		{
			return new login_cancel_queue_ack((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class login_cancel_queue_req : AS3Proto.Message
	{
		public login_cancel_queue_req()
		{
			createAs3Object("SProtoSpace.login_cancel_queue_req");
		}

		private login_cancel_queue_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_cancel_queue_req Create(object rtObject)
		{
			return new login_cancel_queue_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class login_end_queued_ntf : AS3Proto.Message
	{
		public login_end_queued_ntf()
		{
			createAs3Object("SProtoSpace.login_end_queued_ntf");
		}

		private login_end_queued_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_end_queued_ntf Create(object rtObject)
		{
			return new login_end_queued_ntf((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class login_need_queued_ntf : AS3Proto.Message
	{
		public login_need_queued_ntf()
		{
			createAs3Object("SProtoSpace.login_need_queued_ntf");
		}

		private login_need_queued_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_need_queued_ntf Create(object rtObject)
		{
			return new login_need_queued_ntf((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint pos ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			pos = (uint)((player.getMemberValue(as3Object, "pos"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "pos", (pos) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class login_queued_state_ack : AS3Proto.Message
	{
		public login_queued_state_ack()
		{
			createAs3Object("SProtoSpace.login_queued_state_ack");
		}

		private login_queued_state_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_queued_state_ack Create(object rtObject)
		{
			return new login_queued_state_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint pos ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			pos = (uint)((player.getMemberValue(as3Object, "pos"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "pos", (pos) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class login_queued_state_req : AS3Proto.Message
	{
		public login_queued_state_req()
		{
			createAs3Object("SProtoSpace.login_queued_state_req");
		}

		private login_queued_state_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_queued_state_req Create(object rtObject)
		{
			return new login_queued_state_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class login_req : AS3Proto.Message
	{
		public login_req()
		{
			createAs3Object("SProtoSpace.login_req");
		}

		private login_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static login_req Create(object rtObject)
		{
			return new login_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public string account ;
		public string password ;
		public void clearIsdetail(){ player.invokeMethod(as3Object, "clearIsdetail");}
		public bool hasIsdetail{get { return (bool)((player.getMemberValue(as3Object, "hasIsdetail"))); }}
		public bool isdetail{get { return (bool)((player.getMemberValue(as3Object, "isdetail"))); }set { player.setMemberValue(as3Object, "isdetail", (value)); }}
		public void clearUserid(){ player.invokeMethod(as3Object, "clearUserid");}
		public bool hasUserid{get { return (bool)((player.getMemberValue(as3Object, "hasUserid"))); }}
		public string userid{get { return (string)((player.getMemberValue(as3Object, "userid"))); }set { player.setMemberValue(as3Object, "userid", (value)); }}
		public void clearUsersession(){ player.invokeMethod(as3Object, "clearUsersession");}
		public bool hasUsersession{get { return (bool)((player.getMemberValue(as3Object, "hasUsersession"))); }}
		public string usersession{get { return (string)((player.getMemberValue(as3Object, "usersession"))); }set { player.setMemberValue(as3Object, "usersession", (value)); }}
		public void clearLoginType(){ player.invokeMethod(as3Object, "clearLoginType");}
		public bool hasLoginType{get { return (bool)((player.getMemberValue(as3Object, "hasLoginType"))); }}
		public SProtoSpace.EAuthType loginType{get { return (SProtoSpace.EAuthType)((player.getMemberValue(as3Object, "loginType"))); }set { player.setMemberValue(as3Object, "loginType", (int)(value)); }}
		public SProtoSpace.protoId testEnum ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			password = (string)((player.getMemberValue(as3Object, "password"  )));
			testEnum = (SProtoSpace.protoId)((player.getMemberValue(as3Object, "testEnum"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "account", (account) );
			player.setMemberValue(as3Object, "password", (password) );
			player.setMemberValue(as3Object, "testEnum", (int)(testEnum) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class main_task_info : AS3Proto.Message
	{
		public main_task_info()
		{
			createAs3Object("SProtoSpace.main_task_info");
		}

		private main_task_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static main_task_info Create(object rtObject)
		{
			return new main_task_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public int taskid ;
		public int taskstate ;
		public uint curnum ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			taskid = (int)((player.getMemberValue(as3Object, "taskid"  )));
			taskstate = (int)((player.getMemberValue(as3Object, "taskstate"  )));
			curnum = (uint)((player.getMemberValue(as3Object, "curnum"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "taskid", (taskid) );
			player.setMemberValue(as3Object, "taskstate", (taskstate) );
			player.setMemberValue(as3Object, "curnum", (curnum) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class name_check : AS3Proto.Message
	{
		public name_check()
		{
			createAs3Object("SProtoSpace.name_check");
		}

		private name_check(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static name_check Create(object rtObject)
		{
			return new name_check((ASBinCode.rtData.rtObject)rtObject);
		}


		public string name ;
		public void clearAttach(){ player.invokeMethod(as3Object, "clearAttach");}
		public bool hasAttach{get { return (bool)((player.getMemberValue(as3Object, "hasAttach"))); }}
		public string attach{get { return (string)((player.getMemberValue(as3Object, "attach"))); }set { player.setMemberValue(as3Object, "attach", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			name = (string)((player.getMemberValue(as3Object, "name"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "name", (name) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class name_check_ack : AS3Proto.Message
	{
		public name_check_ack()
		{
			createAs3Object("SProtoSpace.name_check_ack");
		}

		private name_check_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static name_check_ack Create(object rtObject)
		{
			return new name_check_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public string name ;
		public int ret ;
		public void clearAttach(){ player.invokeMethod(as3Object, "clearAttach");}
		public bool hasAttach{get { return (bool)((player.getMemberValue(as3Object, "hasAttach"))); }}
		public string attach{get { return (string)((player.getMemberValue(as3Object, "attach"))); }set { player.setMemberValue(as3Object, "attach", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			name = (string)((player.getMemberValue(as3Object, "name"  )));
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "name", (name) );
			player.setMemberValue(as3Object, "ret", (ret) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class player_hero_info : AS3Proto.Message
	{
		public player_hero_info()
		{
			createAs3Object("SProtoSpace.player_hero_info");
		}

		private player_hero_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static player_hero_info Create(object rtObject)
		{
			return new player_hero_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint id ;
		public void clearLevel(){ player.invokeMethod(as3Object, "clearLevel");}
		public bool hasLevel{get { return (bool)((player.getMemberValue(as3Object, "hasLevel"))); }}
		public int level{get { return (int)((player.getMemberValue(as3Object, "level"))); }set { player.setMemberValue(as3Object, "level", (value)); }}
		public void clearStarnum(){ player.invokeMethod(as3Object, "clearStarnum");}
		public bool hasStarnum{get { return (bool)((player.getMemberValue(as3Object, "hasStarnum"))); }}
		public int starnum{get { return (int)((player.getMemberValue(as3Object, "starnum"))); }set { player.setMemberValue(as3Object, "starnum", (value)); }}
		public void clearQuality(){ player.invokeMethod(as3Object, "clearQuality");}
		public bool hasQuality{get { return (bool)((player.getMemberValue(as3Object, "hasQuality"))); }}
		public int quality{get { return (int)((player.getMemberValue(as3Object, "quality"))); }set { player.setMemberValue(as3Object, "quality", (value)); }}
		public System.Collections.Generic.List<SProtoSpace.hero_skill_info> skills ;
		public System.Collections.Generic.List<uint> equips ;
		public void clearHpPercent(){ player.invokeMethod(as3Object, "clearHpPercent");}
		public bool hasHpPercent{get { return (bool)((player.getMemberValue(as3Object, "hasHpPercent"))); }}
		public int hpPercent{get { return (int)((player.getMemberValue(as3Object, "hpPercent"))); }set { player.setMemberValue(as3Object, "hpPercent", (value)); }}
		public void clearHp(){ player.invokeMethod(as3Object, "clearHp");}
		public bool hasHp{get { return (bool)((player.getMemberValue(as3Object, "hasHp"))); }}
		public int hp{get { return (int)((player.getMemberValue(as3Object, "hp"))); }set { player.setMemberValue(as3Object, "hp", (value)); }}
		public void clearMaxHp(){ player.invokeMethod(as3Object, "clearMaxHp");}
		public bool hasMaxHp{get { return (bool)((player.getMemberValue(as3Object, "hasMaxHp"))); }}
		public int maxHp{get { return (int)((player.getMemberValue(as3Object, "maxHp"))); }set { player.setMemberValue(as3Object, "maxHp", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			id = (uint)((player.getMemberValue(as3Object, "id"  )));
			{
				skills = new System.Collections.Generic.List<SProtoSpace.hero_skill_info>();
				uint len = (uint)player.getMemberValue(as3Object, "skills.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.hero_skill_info v = default(SProtoSpace.hero_skill_info);
					{
						var obj = player.getMemberValue(as3Object, "skills",i);
						if (obj !=null)
							v = SProtoSpace.hero_skill_info.Create(obj);
						else
							v = null;
					}

					skills.Add(v);
				}
			}
			{
				equips = new System.Collections.Generic.List<uint>();
				uint len = (uint)player.getMemberValue(as3Object, "equips.length");
				for (int i = 0; i < len; i++)
				{
					uint v = default(uint);
					v = (uint)((player.getMemberValue(as3Object, "equips" ,i )));

					equips.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "id", (id) );
			{
				player.setMemberValue(as3Object, "skills.length", skills.Count);
				for (int i = 0; i < skills.Count; i++)
				{
					var v = skills[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "skills", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "skills", null);
						}
					}
					
				}
			}
			{
				player.setMemberValue(as3Object, "equips.length", equips.Count);
				for (int i = 0; i < equips.Count; i++)
				{
					var v = equips[i];
					player.setMemberValue(as3Object, "equips", (v),i );
					
				}
			}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class player_info_ntf : AS3Proto.Message
	{
		public player_info_ntf()
		{
			createAs3Object("SProtoSpace.player_info_ntf");
		}

		private player_info_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static player_info_ntf Create(object rtObject)
		{
			return new player_info_ntf((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearInfo(){ player.invokeMethod(as3Object, "clearInfo");}
		public bool hasInfo{get { return (bool)((player.getMemberValue(as3Object, "hasInfo"))); }}
		private SProtoSpace.friend_base_info ___info; private bool ___infoflag___;
		public SProtoSpace.friend_base_info info
		{
			get
			{
				if (___info == null && !___infoflag___)
				{
					___infoflag___ = true;
					var obj = player.getMemberValue(as3Object, "info");
					if(obj !=null)
						___info = SProtoSpace.friend_base_info.Create(obj);
				}

				return ___info;
			}
			set
			{
				___info = value;
				if (value != null)
				{
					player.setMemberValue(as3Object, "info", LoadBindObject(value));
				}
				else
				{
					player.setMemberValue(as3Object, "info", null);
				}
			}
		}





	}
}

namespace SProtoSpace
{
	public class player_leave_game_ntf : AS3Proto.Message
	{
		public player_leave_game_ntf()
		{
			createAs3Object("SProtoSpace.player_leave_game_ntf");
		}

		private player_leave_game_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static player_leave_game_ntf Create(object rtObject)
		{
			return new player_leave_game_ntf((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 id ;
		public uint accountid ;
		public uint groupid ;
		public uint level ;
		public uint heroid ;
		public uint lastlogindate ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			id = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "id"  )));
			accountid = (uint)((player.getMemberValue(as3Object, "accountid"  )));
			groupid = (uint)((player.getMemberValue(as3Object, "groupid"  )));
			level = (uint)((player.getMemberValue(as3Object, "level"  )));
			heroid = (uint)((player.getMemberValue(as3Object, "heroid"  )));
			lastlogindate = (uint)((player.getMemberValue(as3Object, "lastlogindate"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "id", ConvertULongToObj(id) );
			player.setMemberValue(as3Object, "accountid", (accountid) );
			player.setMemberValue(as3Object, "groupid", (groupid) );
			player.setMemberValue(as3Object, "level", (level) );
			player.setMemberValue(as3Object, "heroid", (heroid) );
			player.setMemberValue(as3Object, "lastlogindate", (lastlogindate) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class player_leave_game_req : AS3Proto.Message
	{
		public player_leave_game_req()
		{
			createAs3Object("SProtoSpace.player_leave_game_req");
		}

		private player_leave_game_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static player_leave_game_req Create(object rtObject)
		{
			return new player_leave_game_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public enum protoId
	{
		 LOGIN_REQ_ID = 0,
		 LOGIN_ACK_ID = 1,
		 area_list_info_ack_id = 2,
		 login_need_queued_ntf_id = 3,
		 login_end_queued_ntf_id = 4,
		 login_queued_state_req_id = 5,
		 login_queued_state_ack_id = 6,
		 login_cancel_queue_req_id = 7,
		 login_cancel_queue_ack_id = 8,

	}
}

namespace SProtoSpace
{
	public class rand_names_ack : AS3Proto.Message
	{
		public rand_names_ack()
		{
			createAs3Object("SProtoSpace.rand_names_ack");
		}

		private rand_names_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static rand_names_ack Create(object rtObject)
		{
			return new rand_names_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.Collections.Generic.List<String> names ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			{
				names = new System.Collections.Generic.List<String>();
				uint len = (uint)player.getMemberValue(as3Object, "names.length");
				for (int i = 0; i < len; i++)
				{
					String v = default(String);
					v = (String)((player.getMemberValue(as3Object, "names" ,i )));

					names.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			{
				player.setMemberValue(as3Object, "names.length", names.Count);
				for (int i = 0; i < names.Count; i++)
				{
					var v = names[i];
					player.setMemberValue(as3Object, "names", (v),i );
					
				}
			}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class rand_names_req : AS3Proto.Message
	{
		public rand_names_req()
		{
			createAs3Object("SProtoSpace.rand_names_req");
		}

		private rand_names_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static rand_names_req Create(object rtObject)
		{
			return new rand_names_req((ASBinCode.rtData.rtObject)rtObject);
		}







	}
}

namespace SProtoSpace
{
	public class reconnect_to_check_info_ack : AS3Proto.Message
	{
		public reconnect_to_check_info_ack()
		{
			createAs3Object("SProtoSpace.reconnect_to_check_info_ack");
		}

		private reconnect_to_check_info_ack(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static reconnect_to_check_info_ack Create(object rtObject)
		{
			return new reconnect_to_check_info_ack((ASBinCode.rtData.rtObject)rtObject);
		}


		public int ret ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			ret = (int)((player.getMemberValue(as3Object, "ret"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "ret", (ret) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class reconnect_to_check_info_req : AS3Proto.Message
	{
		public reconnect_to_check_info_req()
		{
			createAs3Object("SProtoSpace.reconnect_to_check_info_req");
		}

		private reconnect_to_check_info_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static reconnect_to_check_info_req Create(object rtObject)
		{
			return new reconnect_to_check_info_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 llid ;
		public string account ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			llid = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "llid"  )));
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "llid", ConvertULongToObj(llid) );
			player.setMemberValue(as3Object, "account", (account) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class role_bag_info : AS3Proto.Message
	{
		public role_bag_info()
		{
			createAs3Object("SProtoSpace.role_bag_info");
		}

		private role_bag_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static role_bag_info Create(object rtObject)
		{
			return new role_bag_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint templateid ;
		public void clearNum(){ player.invokeMethod(as3Object, "clearNum");}
		public bool hasNum{get { return (bool)((player.getMemberValue(as3Object, "hasNum"))); }}
		public int num{get { return (int)((player.getMemberValue(as3Object, "num"))); }set { player.setMemberValue(as3Object, "num", (value)); }}
		public void clearStar(){ player.invokeMethod(as3Object, "clearStar");}
		public bool hasStar{get { return (bool)((player.getMemberValue(as3Object, "hasStar"))); }}
		public int star{get { return (int)((player.getMemberValue(as3Object, "star"))); }set { player.setMemberValue(as3Object, "star", (value)); }}
		public void clearLevel(){ player.invokeMethod(as3Object, "clearLevel");}
		public bool hasLevel{get { return (bool)((player.getMemberValue(as3Object, "hasLevel"))); }}
		public int level{get { return (int)((player.getMemberValue(as3Object, "level"))); }set { player.setMemberValue(as3Object, "level", (value)); }}
		public void clearCurMaxLevel(){ player.invokeMethod(as3Object, "clearCurMaxLevel");}
		public bool hasCurMaxLevel{get { return (bool)((player.getMemberValue(as3Object, "hasCurMaxLevel"))); }}
		public int curMaxLevel{get { return (int)((player.getMemberValue(as3Object, "curMaxLevel"))); }set { player.setMemberValue(as3Object, "curMaxLevel", (value)); }}
		public void clearCurMaxStars(){ player.invokeMethod(as3Object, "clearCurMaxStars");}
		public bool hasCurMaxStars{get { return (bool)((player.getMemberValue(as3Object, "hasCurMaxStars"))); }}
		public int curMaxStars{get { return (int)((player.getMemberValue(as3Object, "curMaxStars"))); }set { player.setMemberValue(as3Object, "curMaxStars", (value)); }}
		public void clearStarExp(){ player.invokeMethod(as3Object, "clearStarExp");}
		public bool hasStarExp{get { return (bool)((player.getMemberValue(as3Object, "hasStarExp"))); }}
		public int starExp{get { return (int)((player.getMemberValue(as3Object, "starExp"))); }set { player.setMemberValue(as3Object, "starExp", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			templateid = (uint)((player.getMemberValue(as3Object, "templateid"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "templateid", (templateid) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class role_base_info : AS3Proto.Message
	{
		public role_base_info()
		{
			createAs3Object("SProtoSpace.role_base_info");
		}

		private role_base_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static role_base_info Create(object rtObject)
		{
			return new role_base_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public void clearLevel(){ player.invokeMethod(as3Object, "clearLevel");}
		public bool hasLevel{get { return (bool)((player.getMemberValue(as3Object, "hasLevel"))); }}
		public int level{get { return (int)((player.getMemberValue(as3Object, "level"))); }set { player.setMemberValue(as3Object, "level", (value)); }}
		public void clearCommonscene(){ player.invokeMethod(as3Object, "clearCommonscene");}
		public bool hasCommonscene{get { return (bool)((player.getMemberValue(as3Object, "hasCommonscene"))); }}
		public int commonscene{get { return (int)((player.getMemberValue(as3Object, "commonscene"))); }set { player.setMemberValue(as3Object, "commonscene", (value)); }}
		public void clearHardscene(){ player.invokeMethod(as3Object, "clearHardscene");}
		public bool hasHardscene{get { return (bool)((player.getMemberValue(as3Object, "hasHardscene"))); }}
		public int hardscene{get { return (int)((player.getMemberValue(as3Object, "hardscene"))); }set { player.setMemberValue(as3Object, "hardscene", (value)); }}
		public void clearAccount(){ player.invokeMethod(as3Object, "clearAccount");}
		public bool hasAccount{get { return (bool)((player.getMemberValue(as3Object, "hasAccount"))); }}
		public string account{get { return (string)((player.getMemberValue(as3Object, "account"))); }set { player.setMemberValue(as3Object, "account", (value)); }}
		public void clearHeroid(){ player.invokeMethod(as3Object, "clearHeroid");}
		public bool hasHeroid{get { return (bool)((player.getMemberValue(as3Object, "hasHeroid"))); }}
		public uint heroid{get { return (uint)((player.getMemberValue(as3Object, "heroid"))); }set { player.setMemberValue(as3Object, "heroid", (value)); }}
		public void clearVp(){ player.invokeMethod(as3Object, "clearVp");}
		public bool hasVp{get { return (bool)((player.getMemberValue(as3Object, "hasVp"))); }}
		public uint vp{get { return (uint)((player.getMemberValue(as3Object, "vp"))); }set { player.setMemberValue(as3Object, "vp", (value)); }}
		public void clearVpUpdateTime(){ player.invokeMethod(as3Object, "clearVpUpdateTime");}
		public bool hasVpUpdateTime{get { return (bool)((player.getMemberValue(as3Object, "hasVpUpdateTime"))); }}
		public uint vpUpdateTime{get { return (uint)((player.getMemberValue(as3Object, "vpUpdateTime"))); }set { player.setMemberValue(as3Object, "vpUpdateTime", (value)); }}
		public void clearExp(){ player.invokeMethod(as3Object, "clearExp");}
		public bool hasExp{get { return (bool)((player.getMemberValue(as3Object, "hasExp"))); }}
		public uint exp{get { return (uint)((player.getMemberValue(as3Object, "exp"))); }set { player.setMemberValue(as3Object, "exp", (value)); }}
		public void clearCoin(){ player.invokeMethod(as3Object, "clearCoin");}
		public bool hasCoin{get { return (bool)((player.getMemberValue(as3Object, "hasCoin"))); }}
		public uint coin{get { return (uint)((player.getMemberValue(as3Object, "coin"))); }set { player.setMemberValue(as3Object, "coin", (value)); }}
		public void clearDiamond(){ player.invokeMethod(as3Object, "clearDiamond");}
		public bool hasDiamond{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond"))); }}
		public uint diamond{get { return (uint)((player.getMemberValue(as3Object, "diamond"))); }set { player.setMemberValue(as3Object, "diamond", (value)); }}
		public void clearViplevel(){ player.invokeMethod(as3Object, "clearViplevel");}
		public bool hasViplevel{get { return (bool)((player.getMemberValue(as3Object, "hasViplevel"))); }}
		public int viplevel{get { return (int)((player.getMemberValue(as3Object, "viplevel"))); }set { player.setMemberValue(as3Object, "viplevel", (value)); }}
		public void clearVipexp(){ player.invokeMethod(as3Object, "clearVipexp");}
		public bool hasVipexp{get { return (bool)((player.getMemberValue(as3Object, "hasVipexp"))); }}
		public int vipexp{get { return (int)((player.getMemberValue(as3Object, "vipexp"))); }set { player.setMemberValue(as3Object, "vipexp", (value)); }}
		public void clearLastleavetime(){ player.invokeMethod(as3Object, "clearLastleavetime");}
		public bool hasLastleavetime{get { return (bool)((player.getMemberValue(as3Object, "hasLastleavetime"))); }}
		public uint lastleavetime{get { return (uint)((player.getMemberValue(as3Object, "lastleavetime"))); }set { player.setMemberValue(as3Object, "lastleavetime", (value)); }}
		public void clearOnemoneycardingtime(){ player.invokeMethod(as3Object, "clearOnemoneycardingtime");}
		public bool hasOnemoneycardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasOnemoneycardingtime"))); }}
		public uint onemoneycardingtime{get { return (uint)((player.getMemberValue(as3Object, "onemoneycardingtime"))); }set { player.setMemberValue(as3Object, "onemoneycardingtime", (value)); }}
		public void clearOnemoneycardingcount(){ player.invokeMethod(as3Object, "clearOnemoneycardingcount");}
		public bool hasOnemoneycardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasOnemoneycardingcount"))); }}
		public int onemoneycardingcount{get { return (int)((player.getMemberValue(as3Object, "onemoneycardingcount"))); }set { player.setMemberValue(as3Object, "onemoneycardingcount", (value)); }}
		public void clearTenmoneycardingtime(){ player.invokeMethod(as3Object, "clearTenmoneycardingtime");}
		public bool hasTenmoneycardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasTenmoneycardingtime"))); }}
		public uint tenmoneycardingtime{get { return (uint)((player.getMemberValue(as3Object, "tenmoneycardingtime"))); }set { player.setMemberValue(as3Object, "tenmoneycardingtime", (value)); }}
		public void clearTenmoneycardingcount(){ player.invokeMethod(as3Object, "clearTenmoneycardingcount");}
		public bool hasTenmoneycardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasTenmoneycardingcount"))); }}
		public int tenmoneycardingcount{get { return (int)((player.getMemberValue(as3Object, "tenmoneycardingcount"))); }set { player.setMemberValue(as3Object, "tenmoneycardingcount", (value)); }}
		public void clearOnegoldcardingtime(){ player.invokeMethod(as3Object, "clearOnegoldcardingtime");}
		public bool hasOnegoldcardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasOnegoldcardingtime"))); }}
		public uint onegoldcardingtime{get { return (uint)((player.getMemberValue(as3Object, "onegoldcardingtime"))); }set { player.setMemberValue(as3Object, "onegoldcardingtime", (value)); }}
		public void clearOnegoldcardingcount(){ player.invokeMethod(as3Object, "clearOnegoldcardingcount");}
		public bool hasOnegoldcardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasOnegoldcardingcount"))); }}
		public int onegoldcardingcount{get { return (int)((player.getMemberValue(as3Object, "onegoldcardingcount"))); }set { player.setMemberValue(as3Object, "onegoldcardingcount", (value)); }}
		public void clearTengoldcardingtime(){ player.invokeMethod(as3Object, "clearTengoldcardingtime");}
		public bool hasTengoldcardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasTengoldcardingtime"))); }}
		public uint tengoldcardingtime{get { return (uint)((player.getMemberValue(as3Object, "tengoldcardingtime"))); }set { player.setMemberValue(as3Object, "tengoldcardingtime", (value)); }}
		public void clearTengoldcardingcount(){ player.invokeMethod(as3Object, "clearTengoldcardingcount");}
		public bool hasTengoldcardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasTengoldcardingcount"))); }}
		public int tengoldcardingcount{get { return (int)((player.getMemberValue(as3Object, "tengoldcardingcount"))); }set { player.setMemberValue(as3Object, "tengoldcardingcount", (value)); }}
		public void clearOneequipmoneycardingtime(){ player.invokeMethod(as3Object, "clearOneequipmoneycardingtime");}
		public bool hasOneequipmoneycardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasOneequipmoneycardingtime"))); }}
		public uint oneequipmoneycardingtime{get { return (uint)((player.getMemberValue(as3Object, "oneequipmoneycardingtime"))); }set { player.setMemberValue(as3Object, "oneequipmoneycardingtime", (value)); }}
		public void clearOneequipmoneycardingcount(){ player.invokeMethod(as3Object, "clearOneequipmoneycardingcount");}
		public bool hasOneequipmoneycardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasOneequipmoneycardingcount"))); }}
		public int oneequipmoneycardingcount{get { return (int)((player.getMemberValue(as3Object, "oneequipmoneycardingcount"))); }set { player.setMemberValue(as3Object, "oneequipmoneycardingcount", (value)); }}
		public void clearTenequipmoneycardingtime(){ player.invokeMethod(as3Object, "clearTenequipmoneycardingtime");}
		public bool hasTenequipmoneycardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasTenequipmoneycardingtime"))); }}
		public uint tenequipmoneycardingtime{get { return (uint)((player.getMemberValue(as3Object, "tenequipmoneycardingtime"))); }set { player.setMemberValue(as3Object, "tenequipmoneycardingtime", (value)); }}
		public void clearTenequipmoneycardingcount(){ player.invokeMethod(as3Object, "clearTenequipmoneycardingcount");}
		public bool hasTenequipmoneycardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasTenequipmoneycardingcount"))); }}
		public int tenequipmoneycardingcount{get { return (int)((player.getMemberValue(as3Object, "tenequipmoneycardingcount"))); }set { player.setMemberValue(as3Object, "tenequipmoneycardingcount", (value)); }}
		public void clearOneequipgoldcardingtime(){ player.invokeMethod(as3Object, "clearOneequipgoldcardingtime");}
		public bool hasOneequipgoldcardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasOneequipgoldcardingtime"))); }}
		public uint oneequipgoldcardingtime{get { return (uint)((player.getMemberValue(as3Object, "oneequipgoldcardingtime"))); }set { player.setMemberValue(as3Object, "oneequipgoldcardingtime", (value)); }}
		public void clearOneequipgoldcardingcount(){ player.invokeMethod(as3Object, "clearOneequipgoldcardingcount");}
		public bool hasOneequipgoldcardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasOneequipgoldcardingcount"))); }}
		public int oneequipgoldcardingcount{get { return (int)((player.getMemberValue(as3Object, "oneequipgoldcardingcount"))); }set { player.setMemberValue(as3Object, "oneequipgoldcardingcount", (value)); }}
		public void clearTenequipgoldcardingtime(){ player.invokeMethod(as3Object, "clearTenequipgoldcardingtime");}
		public bool hasTenequipgoldcardingtime{get { return (bool)((player.getMemberValue(as3Object, "hasTenequipgoldcardingtime"))); }}
		public uint tenequipgoldcardingtime{get { return (uint)((player.getMemberValue(as3Object, "tenequipgoldcardingtime"))); }set { player.setMemberValue(as3Object, "tenequipgoldcardingtime", (value)); }}
		public void clearTenequipgoldcardingcount(){ player.invokeMethod(as3Object, "clearTenequipgoldcardingcount");}
		public bool hasTenequipgoldcardingcount{get { return (bool)((player.getMemberValue(as3Object, "hasTenequipgoldcardingcount"))); }}
		public int tenequipgoldcardingcount{get { return (int)((player.getMemberValue(as3Object, "tenequipgoldcardingcount"))); }set { player.setMemberValue(as3Object, "tenequipgoldcardingcount", (value)); }}
		public void clearDiamond2cointime(){ player.invokeMethod(as3Object, "clearDiamond2cointime");}
		public bool hasDiamond2cointime{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2cointime"))); }}
		public uint diamond2cointime{get { return (uint)((player.getMemberValue(as3Object, "diamond2cointime"))); }set { player.setMemberValue(as3Object, "diamond2cointime", (value)); }}
		public void clearDiamond2coincount(){ player.invokeMethod(as3Object, "clearDiamond2coincount");}
		public bool hasDiamond2coincount{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2coincount"))); }}
		public int diamond2coincount{get { return (int)((player.getMemberValue(as3Object, "diamond2coincount"))); }set { player.setMemberValue(as3Object, "diamond2coincount", (value)); }}
		public void clearDiamond2energytime(){ player.invokeMethod(as3Object, "clearDiamond2energytime");}
		public bool hasDiamond2energytime{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2energytime"))); }}
		public uint diamond2energytime{get { return (uint)((player.getMemberValue(as3Object, "diamond2energytime"))); }set { player.setMemberValue(as3Object, "diamond2energytime", (value)); }}
		public void clearDiamond2energycount(){ player.invokeMethod(as3Object, "clearDiamond2energycount");}
		public bool hasDiamond2energycount{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2energycount"))); }}
		public int diamond2energycount{get { return (int)((player.getMemberValue(as3Object, "diamond2energycount"))); }set { player.setMemberValue(as3Object, "diamond2energycount", (value)); }}
		public void clearSkillnum(){ player.invokeMethod(as3Object, "clearSkillnum");}
		public bool hasSkillnum{get { return (bool)((player.getMemberValue(as3Object, "hasSkillnum"))); }}
		public int skillnum{get { return (int)((player.getMemberValue(as3Object, "skillnum"))); }set { player.setMemberValue(as3Object, "skillnum", (value)); }}
		public void clearSkillnumUpdateTime(){ player.invokeMethod(as3Object, "clearSkillnumUpdateTime");}
		public bool hasSkillnumUpdateTime{get { return (bool)((player.getMemberValue(as3Object, "hasSkillnumUpdateTime"))); }}
		public uint skillnumUpdateTime{get { return (uint)((player.getMemberValue(as3Object, "skillnumUpdateTime"))); }set { player.setMemberValue(as3Object, "skillnumUpdateTime", (value)); }}
		public void clearDiamond2skillnumtime(){ player.invokeMethod(as3Object, "clearDiamond2skillnumtime");}
		public bool hasDiamond2skillnumtime{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2skillnumtime"))); }}
		public uint diamond2skillnumtime{get { return (uint)((player.getMemberValue(as3Object, "diamond2skillnumtime"))); }set { player.setMemberValue(as3Object, "diamond2skillnumtime", (value)); }}
		public void clearDiamond2skillnumcount(){ player.invokeMethod(as3Object, "clearDiamond2skillnumcount");}
		public bool hasDiamond2skillnumcount{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2skillnumcount"))); }}
		public int diamond2skillnumcount{get { return (int)((player.getMemberValue(as3Object, "diamond2skillnumcount"))); }set { player.setMemberValue(as3Object, "diamond2skillnumcount", (value)); }}
		public void clearWorldchattime(){ player.invokeMethod(as3Object, "clearWorldchattime");}
		public bool hasWorldchattime{get { return (bool)((player.getMemberValue(as3Object, "hasWorldchattime"))); }}
		public uint worldchattime{get { return (uint)((player.getMemberValue(as3Object, "worldchattime"))); }set { player.setMemberValue(as3Object, "worldchattime", (value)); }}
		public void clearWorldchatcount(){ player.invokeMethod(as3Object, "clearWorldchatcount");}
		public bool hasWorldchatcount{get { return (bool)((player.getMemberValue(as3Object, "hasWorldchatcount"))); }}
		public int worldchatcount{get { return (int)((player.getMemberValue(as3Object, "worldchatcount"))); }set { player.setMemberValue(as3Object, "worldchatcount", (value)); }}
		public void clearArenatime(){ player.invokeMethod(as3Object, "clearArenatime");}
		public bool hasArenatime{get { return (bool)((player.getMemberValue(as3Object, "hasArenatime"))); }}
		public uint arenatime{get { return (uint)((player.getMemberValue(as3Object, "arenatime"))); }set { player.setMemberValue(as3Object, "arenatime", (value)); }}
		public void clearArenacount(){ player.invokeMethod(as3Object, "clearArenacount");}
		public bool hasArenacount{get { return (bool)((player.getMemberValue(as3Object, "hasArenacount"))); }}
		public int arenacount{get { return (int)((player.getMemberValue(as3Object, "arenacount"))); }set { player.setMemberValue(as3Object, "arenacount", (value)); }}
		public void clearArenacdtime(){ player.invokeMethod(as3Object, "clearArenacdtime");}
		public bool hasArenacdtime{get { return (bool)((player.getMemberValue(as3Object, "hasArenacdtime"))); }}
		public uint arenacdtime{get { return (uint)((player.getMemberValue(as3Object, "arenacdtime"))); }set { player.setMemberValue(as3Object, "arenacdtime", (value)); }}
		public void clearArenacdvalue(){ player.invokeMethod(as3Object, "clearArenacdvalue");}
		public bool hasArenacdvalue{get { return (bool)((player.getMemberValue(as3Object, "hasArenacdvalue"))); }}
		public int arenacdvalue{get { return (int)((player.getMemberValue(as3Object, "arenacdvalue"))); }set { player.setMemberValue(as3Object, "arenacdvalue", (value)); }}
		public void clearArenaResetcdTime(){ player.invokeMethod(as3Object, "clearArenaResetcdTime");}
		public bool hasArenaResetcdTime{get { return (bool)((player.getMemberValue(as3Object, "hasArenaResetcdTime"))); }}
		public uint arenaResetcdTime{get { return (uint)((player.getMemberValue(as3Object, "arenaResetcdTime"))); }set { player.setMemberValue(as3Object, "arenaResetcdTime", (value)); }}
		public void clearArenaResetcdCount(){ player.invokeMethod(as3Object, "clearArenaResetcdCount");}
		public bool hasArenaResetcdCount{get { return (bool)((player.getMemberValue(as3Object, "hasArenaResetcdCount"))); }}
		public int arenaResetcdCount{get { return (int)((player.getMemberValue(as3Object, "arenaResetcdCount"))); }set { player.setMemberValue(as3Object, "arenaResetcdCount", (value)); }}
		public void clearArenaBuycountTime(){ player.invokeMethod(as3Object, "clearArenaBuycountTime");}
		public bool hasArenaBuycountTime{get { return (bool)((player.getMemberValue(as3Object, "hasArenaBuycountTime"))); }}
		public uint arenaBuycountTime{get { return (uint)((player.getMemberValue(as3Object, "arenaBuycountTime"))); }set { player.setMemberValue(as3Object, "arenaBuycountTime", (value)); }}
		public void clearArenaBuycountNum(){ player.invokeMethod(as3Object, "clearArenaBuycountNum");}
		public bool hasArenaBuycountNum{get { return (bool)((player.getMemberValue(as3Object, "hasArenaBuycountNum"))); }}
		public int arenaBuycountNum{get { return (int)((player.getMemberValue(as3Object, "arenaBuycountNum"))); }set { player.setMemberValue(as3Object, "arenaBuycountNum", (value)); }}
		public void clearArenaCoin(){ player.invokeMethod(as3Object, "clearArenaCoin");}
		public bool hasArenaCoin{get { return (bool)((player.getMemberValue(as3Object, "hasArenaCoin"))); }}
		public int arenaCoin{get { return (int)((player.getMemberValue(as3Object, "arenaCoin"))); }set { player.setMemberValue(as3Object, "arenaCoin", (value)); }}
		public void clearTitleId(){ player.invokeMethod(as3Object, "clearTitleId");}
		public bool hasTitleId{get { return (bool)((player.getMemberValue(as3Object, "hasTitleId"))); }}
		public int titleId{get { return (int)((player.getMemberValue(as3Object, "titleId"))); }set { player.setMemberValue(as3Object, "titleId", (value)); }}
		public void clearTitleCredit(){ player.invokeMethod(as3Object, "clearTitleCredit");}
		public bool hasTitleCredit{get { return (bool)((player.getMemberValue(as3Object, "hasTitleCredit"))); }}
		public int titleCredit{get { return (int)((player.getMemberValue(as3Object, "titleCredit"))); }set { player.setMemberValue(as3Object, "titleCredit", (value)); }}
		public void clearTitleStar(){ player.invokeMethod(as3Object, "clearTitleStar");}
		public bool hasTitleStar{get { return (bool)((player.getMemberValue(as3Object, "hasTitleStar"))); }}
		public int titleStar{get { return (int)((player.getMemberValue(as3Object, "titleStar"))); }set { player.setMemberValue(as3Object, "titleStar", (value)); }}
		public void clearSignWeekDays(){ player.invokeMethod(as3Object, "clearSignWeekDays");}
		public bool hasSignWeekDays{get { return (bool)((player.getMemberValue(as3Object, "hasSignWeekDays"))); }}
		public int signWeekDays{get { return (int)((player.getMemberValue(as3Object, "signWeekDays"))); }set { player.setMemberValue(as3Object, "signWeekDays", (value)); }}
		public void clearSignWeekLastTime(){ player.invokeMethod(as3Object, "clearSignWeekLastTime");}
		public bool hasSignWeekLastTime{get { return (bool)((player.getMemberValue(as3Object, "hasSignWeekLastTime"))); }}
		public uint signWeekLastTime{get { return (uint)((player.getMemberValue(as3Object, "signWeekLastTime"))); }set { player.setMemberValue(as3Object, "signWeekLastTime", (value)); }}
		public void clearSignMonthDays(){ player.invokeMethod(as3Object, "clearSignMonthDays");}
		public bool hasSignMonthDays{get { return (bool)((player.getMemberValue(as3Object, "hasSignMonthDays"))); }}
		public int signMonthDays{get { return (int)((player.getMemberValue(as3Object, "signMonthDays"))); }set { player.setMemberValue(as3Object, "signMonthDays", (value)); }}
		public void clearSignMonthLastTime(){ player.invokeMethod(as3Object, "clearSignMonthLastTime");}
		public bool hasSignMonthLastTime{get { return (bool)((player.getMemberValue(as3Object, "hasSignMonthLastTime"))); }}
		public uint signMonthLastTime{get { return (uint)((player.getMemberValue(as3Object, "signMonthLastTime"))); }set { player.setMemberValue(as3Object, "signMonthLastTime", (value)); }}
		public void clearResignMonthDays(){ player.invokeMethod(as3Object, "clearResignMonthDays");}
		public bool hasResignMonthDays{get { return (bool)((player.getMemberValue(as3Object, "hasResignMonthDays"))); }}
		public int resignMonthDays{get { return (int)((player.getMemberValue(as3Object, "resignMonthDays"))); }set { player.setMemberValue(as3Object, "resignMonthDays", (value)); }}
		public System.Collections.Generic.List<int> periodPrizeDays ;
		public void clearDecomposeCoin(){ player.invokeMethod(as3Object, "clearDecomposeCoin");}
		public bool hasDecomposeCoin{get { return (bool)((player.getMemberValue(as3Object, "hasDecomposeCoin"))); }}
		public int decomposeCoin{get { return (int)((player.getMemberValue(as3Object, "decomposeCoin"))); }set { player.setMemberValue(as3Object, "decomposeCoin", (value)); }}
		public void clearMobaCoin(){ player.invokeMethod(as3Object, "clearMobaCoin");}
		public bool hasMobaCoin{get { return (bool)((player.getMemberValue(as3Object, "hasMobaCoin"))); }}
		public int mobaCoin{get { return (int)((player.getMemberValue(as3Object, "mobaCoin"))); }set { player.setMemberValue(as3Object, "mobaCoin", (value)); }}
		public void clearMobaExp(){ player.invokeMethod(as3Object, "clearMobaExp");}
		public bool hasMobaExp{get { return (bool)((player.getMemberValue(as3Object, "hasMobaExp"))); }}
		public int mobaExp{get { return (int)((player.getMemberValue(as3Object, "mobaExp"))); }set { player.setMemberValue(as3Object, "mobaExp", (value)); }}
		public void clearMobaPoint(){ player.invokeMethod(as3Object, "clearMobaPoint");}
		public bool hasMobaPoint{get { return (bool)((player.getMemberValue(as3Object, "hasMobaPoint"))); }}
		public int mobaPoint{get { return (int)((player.getMemberValue(as3Object, "mobaPoint"))); }set { player.setMemberValue(as3Object, "mobaPoint", (value)); }}
		public void clearTodayMobacoin(){ player.invokeMethod(as3Object, "clearTodayMobacoin");}
		public bool hasTodayMobacoin{get { return (bool)((player.getMemberValue(as3Object, "hasTodayMobacoin"))); }}
		public int todayMobacoin{get { return (int)((player.getMemberValue(as3Object, "todayMobacoin"))); }set { player.setMemberValue(as3Object, "todayMobacoin", (value)); }}
		public void clearTodayMobaexp(){ player.invokeMethod(as3Object, "clearTodayMobaexp");}
		public bool hasTodayMobaexp{get { return (bool)((player.getMemberValue(as3Object, "hasTodayMobaexp"))); }}
		public int todayMobaexp{get { return (int)((player.getMemberValue(as3Object, "todayMobaexp"))); }set { player.setMemberValue(as3Object, "todayMobaexp", (value)); }}
		public void clearTodayTeamcoin(){ player.invokeMethod(as3Object, "clearTodayTeamcoin");}
		public bool hasTodayTeamcoin{get { return (bool)((player.getMemberValue(as3Object, "hasTodayTeamcoin"))); }}
		public int todayTeamcoin{get { return (int)((player.getMemberValue(as3Object, "todayTeamcoin"))); }set { player.setMemberValue(as3Object, "todayTeamcoin", (value)); }}
		public void clearVipSignedDays(){ player.invokeMethod(as3Object, "clearVipSignedDays");}
		public bool hasVipSignedDays{get { return (bool)((player.getMemberValue(as3Object, "hasVipSignedDays"))); }}
		public int vipSignedDays{get { return (int)((player.getMemberValue(as3Object, "vipSignedDays"))); }set { player.setMemberValue(as3Object, "vipSignedDays", (value)); }}
		public void clearCrystal(){ player.invokeMethod(as3Object, "clearCrystal");}
		public bool hasCrystal{get { return (bool)((player.getMemberValue(as3Object, "hasCrystal"))); }}
		public uint crystal{get { return (uint)((player.getMemberValue(as3Object, "crystal"))); }set { player.setMemberValue(as3Object, "crystal", (value)); }}
		public void clearCrystalUpdateTime(){ player.invokeMethod(as3Object, "clearCrystalUpdateTime");}
		public bool hasCrystalUpdateTime{get { return (bool)((player.getMemberValue(as3Object, "hasCrystalUpdateTime"))); }}
		public uint crystalUpdateTime{get { return (uint)((player.getMemberValue(as3Object, "crystalUpdateTime"))); }set { player.setMemberValue(as3Object, "crystalUpdateTime", (value)); }}
		public void clearCrystalOutputSecond(){ player.invokeMethod(as3Object, "clearCrystalOutputSecond");}
		public bool hasCrystalOutputSecond{get { return (bool)((player.getMemberValue(as3Object, "hasCrystalOutputSecond"))); }}
		public uint crystalOutputSecond{get { return (uint)((player.getMemberValue(as3Object, "crystalOutputSecond"))); }set { player.setMemberValue(as3Object, "crystalOutputSecond", (value)); }}
		public void clearDiamond2crystaltime(){ player.invokeMethod(as3Object, "clearDiamond2crystaltime");}
		public bool hasDiamond2crystaltime{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2crystaltime"))); }}
		public uint diamond2crystaltime{get { return (uint)((player.getMemberValue(as3Object, "diamond2crystaltime"))); }set { player.setMemberValue(as3Object, "diamond2crystaltime", (value)); }}
		public void clearDiamond2crystalcount(){ player.invokeMethod(as3Object, "clearDiamond2crystalcount");}
		public bool hasDiamond2crystalcount{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2crystalcount"))); }}
		public int diamond2crystalcount{get { return (int)((player.getMemberValue(as3Object, "diamond2crystalcount"))); }set { player.setMemberValue(as3Object, "diamond2crystalcount", (value)); }}
		public void clearVigour(){ player.invokeMethod(as3Object, "clearVigour");}
		public bool hasVigour{get { return (bool)((player.getMemberValue(as3Object, "hasVigour"))); }}
		public uint vigour{get { return (uint)((player.getMemberValue(as3Object, "vigour"))); }set { player.setMemberValue(as3Object, "vigour", (value)); }}
		public void clearVigourUpdateTime(){ player.invokeMethod(as3Object, "clearVigourUpdateTime");}
		public bool hasVigourUpdateTime{get { return (bool)((player.getMemberValue(as3Object, "hasVigourUpdateTime"))); }}
		public uint vigourUpdateTime{get { return (uint)((player.getMemberValue(as3Object, "vigourUpdateTime"))); }set { player.setMemberValue(as3Object, "vigourUpdateTime", (value)); }}
		public void clearDiamond2vigourtime(){ player.invokeMethod(as3Object, "clearDiamond2vigourtime");}
		public bool hasDiamond2vigourtime{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2vigourtime"))); }}
		public uint diamond2vigourtime{get { return (uint)((player.getMemberValue(as3Object, "diamond2vigourtime"))); }set { player.setMemberValue(as3Object, "diamond2vigourtime", (value)); }}
		public void clearDiamond2vigourcount(){ player.invokeMethod(as3Object, "clearDiamond2vigourcount");}
		public bool hasDiamond2vigourcount{get { return (bool)((player.getMemberValue(as3Object, "hasDiamond2vigourcount"))); }}
		public uint diamond2vigourcount{get { return (uint)((player.getMemberValue(as3Object, "diamond2vigourcount"))); }set { player.setMemberValue(as3Object, "diamond2vigourcount", (value)); }}
		public void clearRsExp(){ player.invokeMethod(as3Object, "clearRsExp");}
		public bool hasRsExp{get { return (bool)((player.getMemberValue(as3Object, "hasRsExp"))); }}
		public int rsExp{get { return (int)((player.getMemberValue(as3Object, "rsExp"))); }set { player.setMemberValue(as3Object, "rsExp", (value)); }}
		public System.Collections.Generic.List<int> rsReceivedRewardId ;
		public void clearRsReceivedRewardLv(){ player.invokeMethod(as3Object, "clearRsReceivedRewardLv");}
		public bool hasRsReceivedRewardLv{get { return (bool)((player.getMemberValue(as3Object, "hasRsReceivedRewardLv"))); }}
		public int rsReceivedRewardLv{get { return (int)((player.getMemberValue(as3Object, "rsReceivedRewardLv"))); }set { player.setMemberValue(as3Object, "rsReceivedRewardLv", (value)); }}
		public void clearDungeonBuycountTime(){ player.invokeMethod(as3Object, "clearDungeonBuycountTime");}
		public bool hasDungeonBuycountTime{get { return (bool)((player.getMemberValue(as3Object, "hasDungeonBuycountTime"))); }}
		public uint dungeonBuycountTime{get { return (uint)((player.getMemberValue(as3Object, "dungeonBuycountTime"))); }set { player.setMemberValue(as3Object, "dungeonBuycountTime", (value)); }}
		public void clearDungeonBuycountNum(){ player.invokeMethod(as3Object, "clearDungeonBuycountNum");}
		public bool hasDungeonBuycountNum{get { return (bool)((player.getMemberValue(as3Object, "hasDungeonBuycountNum"))); }}
		public int dungeonBuycountNum{get { return (int)((player.getMemberValue(as3Object, "dungeonBuycountNum"))); }set { player.setMemberValue(as3Object, "dungeonBuycountNum", (value)); }}
		public void clearPeerageAvatarId(){ player.invokeMethod(as3Object, "clearPeerageAvatarId");}
		public bool hasPeerageAvatarId{get { return (bool)((player.getMemberValue(as3Object, "hasPeerageAvatarId"))); }}
		public int peerageAvatarId{get { return (int)((player.getMemberValue(as3Object, "peerageAvatarId"))); }set { player.setMemberValue(as3Object, "peerageAvatarId", (value)); }}
		public void clearPeerageLev(){ player.invokeMethod(as3Object, "clearPeerageLev");}
		public bool hasPeerageLev{get { return (bool)((player.getMemberValue(as3Object, "hasPeerageLev"))); }}
		public int peerageLev{get { return (int)((player.getMemberValue(as3Object, "peerageLev"))); }set { player.setMemberValue(as3Object, "peerageLev", (value)); }}
		public void clearPeerageExp(){ player.invokeMethod(as3Object, "clearPeerageExp");}
		public bool hasPeerageExp{get { return (bool)((player.getMemberValue(as3Object, "hasPeerageExp"))); }}
		public int peerageExp{get { return (int)((player.getMemberValue(as3Object, "peerageExp"))); }set { player.setMemberValue(as3Object, "peerageExp", (value)); }}
		public void clearMoneyCardHeroNum(){ player.invokeMethod(as3Object, "clearMoneyCardHeroNum");}
		public bool hasMoneyCardHeroNum{get { return (bool)((player.getMemberValue(as3Object, "hasMoneyCardHeroNum"))); }}
		public int moneyCardHeroNum{get { return (int)((player.getMemberValue(as3Object, "moneyCardHeroNum"))); }set { player.setMemberValue(as3Object, "moneyCardHeroNum", (value)); }}
		public void clearGoldCardHeroNum(){ player.invokeMethod(as3Object, "clearGoldCardHeroNum");}
		public bool hasGoldCardHeroNum{get { return (bool)((player.getMemberValue(as3Object, "hasGoldCardHeroNum"))); }}
		public int goldCardHeroNum{get { return (int)((player.getMemberValue(as3Object, "goldCardHeroNum"))); }set { player.setMemberValue(as3Object, "goldCardHeroNum", (value)); }}
		public void clearArenaUnreadFlag(){ player.invokeMethod(as3Object, "clearArenaUnreadFlag");}
		public bool hasArenaUnreadFlag{get { return (bool)((player.getMemberValue(as3Object, "hasArenaUnreadFlag"))); }}
		public int arenaUnreadFlag{get { return (int)((player.getMemberValue(as3Object, "arenaUnreadFlag"))); }set { player.setMemberValue(as3Object, "arenaUnreadFlag", (value)); }}
		public void clearZodiacSoul(){ player.invokeMethod(as3Object, "clearZodiacSoul");}
		public bool hasZodiacSoul{get { return (bool)((player.getMemberValue(as3Object, "hasZodiacSoul"))); }}
		public uint zodiacSoul{get { return (uint)((player.getMemberValue(as3Object, "zodiacSoul"))); }set { player.setMemberValue(as3Object, "zodiacSoul", (value)); }}
		public void clearLotteryTotalTimes(){ player.invokeMethod(as3Object, "clearLotteryTotalTimes");}
		public bool hasLotteryTotalTimes{get { return (bool)((player.getMemberValue(as3Object, "hasLotteryTotalTimes"))); }}
		public int lotteryTotalTimes{get { return (int)((player.getMemberValue(as3Object, "lotteryTotalTimes"))); }set { player.setMemberValue(as3Object, "lotteryTotalTimes", (value)); }}
		public void clearLotteryFreeNum(){ player.invokeMethod(as3Object, "clearLotteryFreeNum");}
		public bool hasLotteryFreeNum{get { return (bool)((player.getMemberValue(as3Object, "hasLotteryFreeNum"))); }}
		public int lotteryFreeNum{get { return (int)((player.getMemberValue(as3Object, "lotteryFreeNum"))); }set { player.setMemberValue(as3Object, "lotteryFreeNum", (value)); }}
		public void clearLotteryFreeTime(){ player.invokeMethod(as3Object, "clearLotteryFreeTime");}
		public bool hasLotteryFreeTime{get { return (bool)((player.getMemberValue(as3Object, "hasLotteryFreeTime"))); }}
		public int lotteryFreeTime{get { return (int)((player.getMemberValue(as3Object, "lotteryFreeTime"))); }set { player.setMemberValue(as3Object, "lotteryFreeTime", (value)); }}
		public void clearMagicCrystal(){ player.invokeMethod(as3Object, "clearMagicCrystal");}
		public bool hasMagicCrystal{get { return (bool)((player.getMemberValue(as3Object, "hasMagicCrystal"))); }}
		public int magicCrystal{get { return (int)((player.getMemberValue(as3Object, "magicCrystal"))); }set { player.setMemberValue(as3Object, "magicCrystal", (value)); }}
		public void clearBigAwardCountDown(){ player.invokeMethod(as3Object, "clearBigAwardCountDown");}
		public bool hasBigAwardCountDown{get { return (bool)((player.getMemberValue(as3Object, "hasBigAwardCountDown"))); }}
		public int bigAwardCountDown{get { return (int)((player.getMemberValue(as3Object, "bigAwardCountDown"))); }set { player.setMemberValue(as3Object, "bigAwardCountDown", (value)); }}
		public void clearMaxVp(){ player.invokeMethod(as3Object, "clearMaxVp");}
		public bool hasMaxVp{get { return (bool)((player.getMemberValue(as3Object, "hasMaxVp"))); }}
		public uint maxVp{get { return (uint)((player.getMemberValue(as3Object, "maxVp"))); }set { player.setMemberValue(as3Object, "maxVp", (value)); }}
		public void clearUnlockedChapterId(){ player.invokeMethod(as3Object, "clearUnlockedChapterId");}
		public bool hasUnlockedChapterId{get { return (bool)((player.getMemberValue(as3Object, "hasUnlockedChapterId"))); }}
		public uint unlockedChapterId{get { return (uint)((player.getMemberValue(as3Object, "unlockedChapterId"))); }set { player.setMemberValue(as3Object, "unlockedChapterId", (value)); }}
		public void clearUnlockedWorldFogId(){ player.invokeMethod(as3Object, "clearUnlockedWorldFogId");}
		public bool hasUnlockedWorldFogId{get { return (bool)((player.getMemberValue(as3Object, "hasUnlockedWorldFogId"))); }}
		public uint unlockedWorldFogId{get { return (uint)((player.getMemberValue(as3Object, "unlockedWorldFogId"))); }set { player.setMemberValue(as3Object, "unlockedWorldFogId", (value)); }}
		public void clearLiangcao(){ player.invokeMethod(as3Object, "clearLiangcao");}
		public bool hasLiangcao{get { return (bool)((player.getMemberValue(as3Object, "hasLiangcao"))); }}
		public int liangcao{get { return (int)((player.getMemberValue(as3Object, "liangcao"))); }set { player.setMemberValue(as3Object, "liangcao", (value)); }}
		public void clearPlayerCamp(){ player.invokeMethod(as3Object, "clearPlayerCamp");}
		public bool hasPlayerCamp{get { return (bool)((player.getMemberValue(as3Object, "hasPlayerCamp"))); }}
		public int playerCamp{get { return (int)((player.getMemberValue(as3Object, "playerCamp"))); }set { player.setMemberValue(as3Object, "playerCamp", (value)); }}
		public void clearCountryLv(){ player.invokeMethod(as3Object, "clearCountryLv");}
		public bool hasCountryLv{get { return (bool)((player.getMemberValue(as3Object, "hasCountryLv"))); }}
		public int countryLv{get { return (int)((player.getMemberValue(as3Object, "countryLv"))); }set { player.setMemberValue(as3Object, "countryLv", (value)); }}
		public void clearFreePhantom(){ player.invokeMethod(as3Object, "clearFreePhantom");}
		public bool hasFreePhantom{get { return (bool)((player.getMemberValue(as3Object, "hasFreePhantom"))); }}
		public int freePhantom{get { return (int)((player.getMemberValue(as3Object, "freePhantom"))); }set { player.setMemberValue(as3Object, "freePhantom", (value)); }}
		public void clearCanGainPhantomExp(){ player.invokeMethod(as3Object, "clearCanGainPhantomExp");}
		public bool hasCanGainPhantomExp{get { return (bool)((player.getMemberValue(as3Object, "hasCanGainPhantomExp"))); }}
		public int canGainPhantomExp{get { return (int)((player.getMemberValue(as3Object, "canGainPhantomExp"))); }set { player.setMemberValue(as3Object, "canGainPhantomExp", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			{
				periodPrizeDays = new System.Collections.Generic.List<int>();
				uint len = (uint)player.getMemberValue(as3Object, "periodPrizeDays.length");
				for (int i = 0; i < len; i++)
				{
					int v = default(int);
					v = (int)((player.getMemberValue(as3Object, "periodPrizeDays" ,i )));

					periodPrizeDays.Add(v);
				}
			}
			{
				rsReceivedRewardId = new System.Collections.Generic.List<int>();
				uint len = (uint)player.getMemberValue(as3Object, "rsReceivedRewardId.length");
				for (int i = 0; i < len; i++)
				{
					int v = default(int);
					v = (int)((player.getMemberValue(as3Object, "rsReceivedRewardId" ,i )));

					rsReceivedRewardId.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			{
				player.setMemberValue(as3Object, "periodPrizeDays.length", periodPrizeDays.Count);
				for (int i = 0; i < periodPrizeDays.Count; i++)
				{
					var v = periodPrizeDays[i];
					player.setMemberValue(as3Object, "periodPrizeDays", (v),i );
					
				}
			}
			{
				player.setMemberValue(as3Object, "rsReceivedRewardId.length", rsReceivedRewardId.Count);
				for (int i = 0; i < rsReceivedRewardId.Count; i++)
				{
					var v = rsReceivedRewardId[i];
					player.setMemberValue(as3Object, "rsReceivedRewardId", (v),i );
					
				}
			}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class role_connect_in_req : AS3Proto.Message
	{
		public role_connect_in_req()
		{
			createAs3Object("SProtoSpace.role_connect_in_req");
		}

		private role_connect_in_req(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static role_connect_in_req Create(object rtObject)
		{
			return new role_connect_in_req((ASBinCode.rtData.rtObject)rtObject);
		}


		public System.UInt64 playerid ;
		public string account ;
		public void clearCheckServerId(){ player.invokeMethod(as3Object, "clearCheckServerId");}
		public bool hasCheckServerId{get { return (bool)((player.getMemberValue(as3Object, "hasCheckServerId"))); }}
		public uint checkServerId{get { return (uint)((player.getMemberValue(as3Object, "checkServerId"))); }set { player.setMemberValue(as3Object, "checkServerId", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			playerid = (System.UInt64)(ConvertObjToULong(player.getMemberValue(as3Object, "playerid"  )));
			account = (string)((player.getMemberValue(as3Object, "account"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "playerid", ConvertULongToObj(playerid) );
			player.setMemberValue(as3Object, "account", (account) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class role_hero_info : AS3Proto.Message
	{
		public role_hero_info()
		{
			createAs3Object("SProtoSpace.role_hero_info");
		}

		private role_hero_info(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static role_hero_info Create(object rtObject)
		{
			return new role_hero_info((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint id ;
		public void clearLevel(){ player.invokeMethod(as3Object, "clearLevel");}
		public bool hasLevel{get { return (bool)((player.getMemberValue(as3Object, "hasLevel"))); }}
		public int level{get { return (int)((player.getMemberValue(as3Object, "level"))); }set { player.setMemberValue(as3Object, "level", (value)); }}
		public void clearHp(){ player.invokeMethod(as3Object, "clearHp");}
		public bool hasHp{get { return (bool)((player.getMemberValue(as3Object, "hasHp"))); }}
		public int hp{get { return (int)((player.getMemberValue(as3Object, "hp"))); }set { player.setMemberValue(as3Object, "hp", (value)); }}
		public void clearExp(){ player.invokeMethod(as3Object, "clearExp");}
		public bool hasExp{get { return (bool)((player.getMemberValue(as3Object, "hasExp"))); }}
		public uint exp{get { return (uint)((player.getMemberValue(as3Object, "exp"))); }set { player.setMemberValue(as3Object, "exp", (value)); }}
		public void clearStarnum(){ player.invokeMethod(as3Object, "clearStarnum");}
		public bool hasStarnum{get { return (bool)((player.getMemberValue(as3Object, "hasStarnum"))); }}
		public int starnum{get { return (int)((player.getMemberValue(as3Object, "starnum"))); }set { player.setMemberValue(as3Object, "starnum", (value)); }}
		public void clearQuality(){ player.invokeMethod(as3Object, "clearQuality");}
		public bool hasQuality{get { return (bool)((player.getMemberValue(as3Object, "hasQuality"))); }}
		public int quality{get { return (int)((player.getMemberValue(as3Object, "quality"))); }set { player.setMemberValue(as3Object, "quality", (value)); }}
		public System.Collections.Generic.List<SProtoSpace.hero_skill_info> skills ;
		public System.Collections.Generic.List<SProtoSpace.hero_equip_info> equips ;
		public System.Collections.Generic.List<SProtoSpace.hero_symbol_info> symbols ;
		public void clearArenaFlag(){ player.invokeMethod(as3Object, "clearArenaFlag");}
		public bool hasArenaFlag{get { return (bool)((player.getMemberValue(as3Object, "hasArenaFlag"))); }}
		public int arenaFlag{get { return (int)((player.getMemberValue(as3Object, "arenaFlag"))); }set { player.setMemberValue(as3Object, "arenaFlag", (value)); }}
		public void clearBitDestiny(){ player.invokeMethod(as3Object, "clearBitDestiny");}
		public bool hasBitDestiny{get { return (bool)((player.getMemberValue(as3Object, "hasBitDestiny"))); }}
		public int bitDestiny{get { return (int)((player.getMemberValue(as3Object, "bitDestiny"))); }set { player.setMemberValue(as3Object, "bitDestiny", (value)); }}


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			id = (uint)((player.getMemberValue(as3Object, "id"  )));
			{
				skills = new System.Collections.Generic.List<SProtoSpace.hero_skill_info>();
				uint len = (uint)player.getMemberValue(as3Object, "skills.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.hero_skill_info v = default(SProtoSpace.hero_skill_info);
					{
						var obj = player.getMemberValue(as3Object, "skills",i);
						if (obj !=null)
							v = SProtoSpace.hero_skill_info.Create(obj);
						else
							v = null;
					}

					skills.Add(v);
				}
			}
			{
				equips = new System.Collections.Generic.List<SProtoSpace.hero_equip_info>();
				uint len = (uint)player.getMemberValue(as3Object, "equips.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.hero_equip_info v = default(SProtoSpace.hero_equip_info);
					{
						var obj = player.getMemberValue(as3Object, "equips",i);
						if (obj !=null)
							v = SProtoSpace.hero_equip_info.Create(obj);
						else
							v = null;
					}

					equips.Add(v);
				}
			}
			{
				symbols = new System.Collections.Generic.List<SProtoSpace.hero_symbol_info>();
				uint len = (uint)player.getMemberValue(as3Object, "symbols.length");
				for (int i = 0; i < len; i++)
				{
					SProtoSpace.hero_symbol_info v = default(SProtoSpace.hero_symbol_info);
					{
						var obj = player.getMemberValue(as3Object, "symbols",i);
						if (obj !=null)
							v = SProtoSpace.hero_symbol_info.Create(obj);
						else
							v = null;
					}

					symbols.Add(v);
				}
			}
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "id", (id) );
			{
				player.setMemberValue(as3Object, "skills.length", skills.Count);
				for (int i = 0; i < skills.Count; i++)
				{
					var v = skills[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "skills", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "skills", null);
						}
					}
					
				}
			}
			{
				player.setMemberValue(as3Object, "equips.length", equips.Count);
				for (int i = 0; i < equips.Count; i++)
				{
					var v = equips[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "equips", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "equips", null);
						}
					}
					
				}
			}
			{
				player.setMemberValue(as3Object, "symbols.length", symbols.Count);
				for (int i = 0; i < symbols.Count; i++)
				{
					var v = symbols[i];
					{
						if (v != null)
						{
							player.setMemberValue(as3Object, "symbols", LoadBindObjectAndWriteField(v),i);
						}
						else
						{
							player.setMemberValue(as3Object, "symbols", null);
						}
					}
					
				}
			}
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public class sync_time_ntf : AS3Proto.Message
	{
		public sync_time_ntf()
		{
			createAs3Object("SProtoSpace.sync_time_ntf");
		}

		private sync_time_ntf(ASBinCode.rtData.rtObject rtObject)
		{
			setAs3Object(rtObject);
		}

		internal static sync_time_ntf Create(object rtObject)
		{
			return new sync_time_ntf((ASBinCode.rtData.rtObject)rtObject);
		}


		public uint time ;


		private bool _isreadding;
		protected override void afterMergeFrom()
		{
			if(_isreadding) { return;} else { _isreadding=true; }
			try
			{
			time = (uint)((player.getMemberValue(as3Object, "time"  )));
			}
			finally
			{
			_isreadding=false;
			}
		}


		private bool _iswritting;
		protected override void beforeWriteTo()
		{
			if(_iswritting) { return;} else { _iswritting=true; }
			try
			{
			player.setMemberValue(as3Object, "time", (time) );
			}
			finally
			{
			_iswritting=false;
			}
		}

	}
}

namespace SProtoSpace
{
	public enum UserStatus
	{
		 OFFLINE = 0,
		 ONLINE = 1,

	}
}

