using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000230")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetEquipmentUpdateResponse : IMessage<PresetEquipmentUpdateResponse>, IMessage, IEquatable<PresetEquipmentUpdateResponse>, IDeepCloneable<PresetEquipmentUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x2000231")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000232")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class EquipmentRefresh : IMessage<EquipmentRefresh>, IMessage, IEquatable<EquipmentRefresh>, IDeepCloneable<EquipmentRefresh>, IBufferMessage
		{
			[Token(Token = "0x400076F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<EquipmentRefresh> _parser;

			[Token(Token = "0x4000770")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000771")]
			public const int CharacteristicsInfoFieldNumber = 1;

			[Token(Token = "0x4000772")]
			[FieldOffset(Offset = "0x18")]
			private CharacteristicsInfo characteristicsInfo_;

			[Token(Token = "0x4000773")]
			public const int PresetLookFieldNumber = 2;

			[Token(Token = "0x4000774")]
			[FieldOffset(Offset = "0x20")]
			private PresetLook presetLook_;

			[Token(Token = "0x170004C3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<EquipmentRefresh> Parser
			{
				[Token(Token = "0x600164C")]
				[Address(RVA = "0xCDCC10", Offset = "0xCDC010", VA = "0x180CDCC10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004C4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600164D")]
				[Address(RVA = "0xCDCB90", Offset = "0xCDBF90", VA = "0x180CDCB90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004C5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600164E")]
				[Address(RVA = "0xCDCDB0", Offset = "0xCDC1B0", VA = "0x180CDCDB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004C6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacteristicsInfo CharacteristicsInfo
			{
				[Token(Token = "0x6001652")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001653")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x170004C7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PresetLook PresetLook
			{
				[Token(Token = "0x6001654")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001655")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x600164F")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EquipmentRefresh()
			{
			}

			[Token(Token = "0x6001650")]
			[Address(RVA = "0xCDCAF0", Offset = "0xCDBEF0", VA = "0x180CDCAF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EquipmentRefresh(EquipmentRefresh other)
			{
			}

			[Token(Token = "0x6001651")]
			[Address(RVA = "0xCDC6D0", Offset = "0xCDBAD0", VA = "0x180CDC6D0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EquipmentRefresh Clone()
			{
				return null;
			}

			[Token(Token = "0x6001656")]
			[Address(RVA = "0xCDC7A0", Offset = "0xCDBBA0", VA = "0x180CDC7A0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001657")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(EquipmentRefresh other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001658")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001659")]
			[Address(RVA = "0xCDC990", Offset = "0xCDBD90", VA = "0x180CDC990", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600165A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600165B")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600165C")]
			[Address(RVA = "0xCDC610", Offset = "0xCDBA10", VA = "0x180CDC610", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600165D")]
			[Address(RVA = "0xCDC860", Offset = "0xCDBC60", VA = "0x180CDC860", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(EquipmentRefresh other)
			{
			}

			[Token(Token = "0x600165E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600165F")]
			[Address(RVA = "0xCDCC60", Offset = "0xCDC060", VA = "0x180CDCC60", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetEquipmentUpdateResponse> _parser;

	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400076B")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x400076D")]
	public const int EquipmentRefreshFieldNumber = 2;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x20")]
	private Types.EquipmentRefresh equipmentRefresh_;

	[Token(Token = "0x170004BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetEquipmentUpdateResponse> Parser
	{
		[Token(Token = "0x6001637")]
		[Address(RVA = "0xCE4F50", Offset = "0xCE4350", VA = "0x180CE4F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001638")]
		[Address(RVA = "0xCE4EA0", Offset = "0xCE42A0", VA = "0x180CE4EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001639")]
		[Address(RVA = "0xCE50D0", Offset = "0xCE44D0", VA = "0x180CE50D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170004C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.EquipmentRefresh EquipmentRefresh
	{
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600163A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetEquipmentUpdateResponse()
	{
	}

	[Token(Token = "0x600163B")]
	[Address(RVA = "0xCE4D60", Offset = "0xCE4160", VA = "0x180CE4D60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetEquipmentUpdateResponse(PresetEquipmentUpdateResponse other)
	{
	}

	[Token(Token = "0x600163C")]
	[Address(RVA = "0xCE4760", Offset = "0xCE3B60", VA = "0x180CE4760", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetEquipmentUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001641")]
	[Address(RVA = "0xCE48C0", Offset = "0xCE3CC0", VA = "0x180CE48C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001642")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetEquipmentUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001643")]
	[Address(RVA = "0xCE4970", Offset = "0xCE3D70", VA = "0x180CE4970", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001644")]
	[Address(RVA = "0xCE4C00", Offset = "0xCE4000", VA = "0x180CE4C00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001645")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001646")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001647")]
	[Address(RVA = "0xCE46C0", Offset = "0xCE3AC0", VA = "0x180CE46C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001648")]
	[Address(RVA = "0xCE4A30", Offset = "0xCE3E30", VA = "0x180CE4A30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetEquipmentUpdateResponse other)
	{
	}

	[Token(Token = "0x6001649")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600164A")]
	[Address(RVA = "0xCE4FA0", Offset = "0xCE43A0", VA = "0x180CE4FA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
