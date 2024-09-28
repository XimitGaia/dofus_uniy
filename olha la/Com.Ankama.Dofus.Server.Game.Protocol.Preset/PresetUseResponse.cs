using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000213")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetUseResponse : IMessage<PresetUseResponse>, IMessage, IEquatable<PresetUseResponse>, IDeepCloneable<PresetUseResponse>, IBufferMessage
{
	[Token(Token = "0x2000214")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x400070F")]
		None,
		[Token(Token = "0x4000710")]
		ResultEnum,
		[Token(Token = "0x4000711")]
		MissingEquipments
	}

	[Token(Token = "0x2000215")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000216")]
		public enum ResultEnum
		{
			[Token(Token = "0x4000713")]
			[OriginalName("OK")]
			Ok,
			[Token(Token = "0x4000714")]
			[OriginalName("ERROR_COOLDOWN")]
			ErrorCooldown,
			[Token(Token = "0x4000715")]
			[OriginalName("ERROR_BAD_PRESET_UUID")]
			ErrorBadPresetUuid,
			[Token(Token = "0x4000716")]
			[OriginalName("ERROR_INVALID_STATE")]
			ErrorInvalidState,
			[Token(Token = "0x4000717")]
			[OriginalName("ERROR_UNKNOWN")]
			ErrorUnknown,
			[Token(Token = "0x4000718")]
			[OriginalName("ERROR_INVALID_DATA")]
			ErrorInvalidData,
			[Token(Token = "0x4000719")]
			[OriginalName("MISSING_SPELLS")]
			MissingSpells
		}

		[Token(Token = "0x2000217")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MissingEquipments : IMessage<MissingEquipments>, IMessage, IEquatable<MissingEquipments>, IDeepCloneable<MissingEquipments>, IBufferMessage
		{
			[Token(Token = "0x400071A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MissingEquipments> _parser;

			[Token(Token = "0x400071B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400071C")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x400071D")]
			public const int MissingItemGidsFieldNumber = 1;

			[Token(Token = "0x400071E")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_missingItemGids_codec;

			[Token(Token = "0x400071F")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<int> missingItemGids_;

			[Token(Token = "0x4000720")]
			public const int MissingRideModelIdFieldNumber = 2;

			[Token(Token = "0x4000721")]
			[FieldOffset(Offset = "0x10")]
			private static readonly int MissingRideModelIdDefaultValue;

			[Token(Token = "0x4000722")]
			[FieldOffset(Offset = "0x28")]
			private int missingRideModelId_;

			[Token(Token = "0x1700048C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<MissingEquipments> Parser
			{
				[Token(Token = "0x6001546")]
				[Address(RVA = "0xCE1340", Offset = "0xCE0740", VA = "0x180CE1340")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001547")]
				[Address(RVA = "0xCE1250", Offset = "0xCE0650", VA = "0x180CE1250")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001548")]
				[Address(RVA = "0xCE15E0", Offset = "0xCE09E0", VA = "0x180CE15E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<int> MissingItemGids
			{
				[Token(Token = "0x600154C")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000490")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MissingRideModelId
			{
				[Token(Token = "0x600154D")]
				[Address(RVA = "0xCE12D0", Offset = "0xCE06D0", VA = "0x180CE12D0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600154E")]
				[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000491")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasMissingRideModelId
			{
				[Token(Token = "0x600154F")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001549")]
			[Address(RVA = "0xCE1130", Offset = "0xCE0530", VA = "0x180CE1130")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MissingEquipments()
			{
			}

			[Token(Token = "0x600154A")]
			[Address(RVA = "0xCE11B0", Offset = "0xCE05B0", VA = "0x180CE11B0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MissingEquipments(MissingEquipments other)
			{
			}

			[Token(Token = "0x600154B")]
			[Address(RVA = "0xCE0B90", Offset = "0xCDFF90", VA = "0x180CE0B90", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MissingEquipments Clone()
			{
				return null;
			}

			[Token(Token = "0x6001550")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearMissingRideModelId()
			{
			}

			[Token(Token = "0x6001551")]
			[Address(RVA = "0xCE0C60", Offset = "0xCE0060", VA = "0x180CE0C60", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001552")]
			[Address(RVA = "0xCE0D50", Offset = "0xCE0150", VA = "0x180CE0D50", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(MissingEquipments other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001553")]
			[Address(RVA = "0xCE0E10", Offset = "0xCE0210", VA = "0x180CE0E10", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001554")]
			[Address(RVA = "0xCE0F90", Offset = "0xCE0390", VA = "0x180CE0F90", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001555")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001556")]
			[Address(RVA = "0xCE14C0", Offset = "0xCE08C0", VA = "0x180CE14C0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001557")]
			[Address(RVA = "0xCE0A60", Offset = "0xCDFE60", VA = "0x180CE0A60", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001558")]
			[Address(RVA = "0xCE0EF0", Offset = "0xCE02F0", VA = "0x180CE0EF0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(MissingEquipments other)
			{
			}

			[Token(Token = "0x6001559")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600155A")]
			[Address(RVA = "0xCE1390", Offset = "0xCE0790", VA = "0x180CE1390", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetUseResponse> _parser;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400070A")]
	public const int ResultEnumFieldNumber = 1;

	[Token(Token = "0x400070B")]
	public const int MissingEquipmentsFieldNumber = 2;

	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x17000485")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetUseResponse> Parser
	{
		[Token(Token = "0x600152D")]
		[Address(RVA = "0xCEB390", Offset = "0xCEA790", VA = "0x180CEB390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000486")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600152E")]
		[Address(RVA = "0xCEB270", Offset = "0xCEA670", VA = "0x180CEB270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000487")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600152F")]
		[Address(RVA = "0xCEB730", Offset = "0xCEAB30", VA = "0x180CEB730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000488")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ResultEnum ResultEnum
	{
		[Token(Token = "0x6001533")]
		[Address(RVA = "0xCEB3E0", Offset = "0xCEA7E0", VA = "0x180CEB3E0")]
		get
		{
			return default(Types.ResultEnum);
		}
		[Token(Token = "0x6001534")]
		[Address(RVA = "0xCEB770", Offset = "0xCEAB70", VA = "0x180CEB770")]
		set
		{
		}
	}

	[Token(Token = "0x17000489")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasResultEnum
	{
		[Token(Token = "0x6001535")]
		[Address(RVA = "0xCEB320", Offset = "0xCEA720", VA = "0x180CEB320")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.MissingEquipments MissingEquipments
	{
		[Token(Token = "0x6001537")]
		[Address(RVA = "0xCEB330", Offset = "0xCEA730", VA = "0x180CEB330")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700048B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x6001530")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetUseResponse()
	{
	}

	[Token(Token = "0x6001531")]
	[Address(RVA = "0xCEB0A0", Offset = "0xCEA4A0", VA = "0x180CEB0A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetUseResponse(PresetUseResponse other)
	{
	}

	[Token(Token = "0x6001532")]
	[Address(RVA = "0xCEAB00", Offset = "0xCE9F00", VA = "0x180CEAB00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetUseResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001536")]
	[Address(RVA = "0xCEAAE0", Offset = "0xCE9EE0", VA = "0x180CEAAE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearResultEnum()
	{
	}

	[Token(Token = "0x600153A")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearResult()
	{
	}

	[Token(Token = "0x600153B")]
	[Address(RVA = "0xCEAB60", Offset = "0xCE9F60", VA = "0x180CEAB60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600153C")]
	[Address(RVA = "0xCEAC50", Offset = "0xCEA050", VA = "0x180CEAC50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetUseResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600153D")]
	[Address(RVA = "0xCEAD00", Offset = "0xCEA100", VA = "0x180CEAD00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600153E")]
	[Address(RVA = "0xCEAF40", Offset = "0xCEA340", VA = "0x180CEAF40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600153F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001540")]
	[Address(RVA = "0xCEB610", Offset = "0xCEAA10", VA = "0x180CEB610", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001541")]
	[Address(RVA = "0xCEA990", Offset = "0xCE9D90", VA = "0x180CEA990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001542")]
	[Address(RVA = "0xCEAE30", Offset = "0xCEA230", VA = "0x180CEAE30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetUseResponse other)
	{
	}

	[Token(Token = "0x6001543")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001544")]
	[Address(RVA = "0xCEB450", Offset = "0xCEA850", VA = "0x180CEB450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
