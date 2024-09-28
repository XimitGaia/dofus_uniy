using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001CE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacteristicsInfo : IMessage<CharacteristicsInfo>, IMessage, IEquatable<CharacteristicsInfo>, IDeepCloneable<CharacteristicsInfo>, IBufferMessage
{
	[Token(Token = "0x20001CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20001D0")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class CharacteristicsDetails : IMessage<CharacteristicsDetails>, IMessage, IEquatable<CharacteristicsDetails>, IDeepCloneable<CharacteristicsDetails>, IBufferMessage
		{
			[Token(Token = "0x4000626")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<CharacteristicsDetails> _parser;

			[Token(Token = "0x4000627")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000628")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4000629")]
			public const int LimitFieldNumber = 1;

			[Token(Token = "0x400062A")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int LimitDefaultValue;

			[Token(Token = "0x400062B")]
			[FieldOffset(Offset = "0x1C")]
			private int limit_;

			[Token(Token = "0x400062C")]
			public const int FromBaseFieldNumber = 2;

			[Token(Token = "0x400062D")]
			[FieldOffset(Offset = "0x20")]
			private int fromBase_;

			[Token(Token = "0x400062E")]
			public const int FromAllocatedFieldNumber = 3;

			[Token(Token = "0x400062F")]
			[FieldOffset(Offset = "0x24")]
			private int fromAllocated_;

			[Token(Token = "0x4000630")]
			public const int FromEquipmentFieldNumber = 4;

			[Token(Token = "0x4000631")]
			[FieldOffset(Offset = "0x28")]
			private int fromEquipment_;

			[Token(Token = "0x4000632")]
			public const int FromBonusFieldNumber = 5;

			[Token(Token = "0x4000633")]
			[FieldOffset(Offset = "0x2C")]
			private int fromBonus_;

			[Token(Token = "0x4000634")]
			public const int FromInitialBonusFieldNumber = 6;

			[Token(Token = "0x4000635")]
			[FieldOffset(Offset = "0x30")]
			private int fromInitialBonus_;

			[Token(Token = "0x170003F1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<CharacteristicsDetails> Parser
			{
				[Token(Token = "0x600126F")]
				[Address(RVA = "0xCBFC90", Offset = "0xCBF090", VA = "0x180CBFC90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003F2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001270")]
				[Address(RVA = "0xCBFBA0", Offset = "0xCBEFA0", VA = "0x180CBFBA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003F3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001271")]
				[Address(RVA = "0xCBFF60", Offset = "0xCBF360", VA = "0x180CBFF60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003F4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Limit
			{
				[Token(Token = "0x6001275")]
				[Address(RVA = "0xCBFC20", Offset = "0xCBF020", VA = "0x180CBFC20")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001276")]
				[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
				set
				{
				}
			}

			[Token(Token = "0x170003F5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasLimit
			{
				[Token(Token = "0x6001277")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170003F6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int FromBase
			{
				[Token(Token = "0x6001279")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600127A")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x170003F7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FromAllocated
			{
				[Token(Token = "0x600127B")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600127C")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x170003F8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FromEquipment
			{
				[Token(Token = "0x600127D")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600127E")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x170003F9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FromBonus
			{
				[Token(Token = "0x600127F")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001280")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x170003FA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FromInitialBonus
			{
				[Token(Token = "0x6001281")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001282")]
				[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
				set
				{
				}
			}

			[Token(Token = "0x6001272")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacteristicsDetails()
			{
			}

			[Token(Token = "0x6001273")]
			[Address(RVA = "0xA4B4A0", Offset = "0xA4A8A0", VA = "0x180A4B4A0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacteristicsDetails(CharacteristicsDetails other)
			{
			}

			[Token(Token = "0x6001274")]
			[Address(RVA = "0xCBF640", Offset = "0xCBEA40", VA = "0x180CBF640", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacteristicsDetails Clone()
			{
				return null;
			}

			[Token(Token = "0x6001278")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearLimit()
			{
			}

			[Token(Token = "0x6001283")]
			[Address(RVA = "0xCBF6E0", Offset = "0xCBEAE0", VA = "0x180CBF6E0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001284")]
			[Address(RVA = "0xCBF7C0", Offset = "0xCBEBC0", VA = "0x180CBF7C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(CharacteristicsDetails other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001285")]
			[Address(RVA = "0xCBF860", Offset = "0xCBEC60", VA = "0x180CBF860", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001286")]
			[Address(RVA = "0xCBFA30", Offset = "0xCBEE30", VA = "0x180CBFA30", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001287")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001288")]
			[Address(RVA = "0xCBFE10", Offset = "0xCBF210", VA = "0x180CBFE10", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001289")]
			[Address(RVA = "0xCBF490", Offset = "0xCBE890", VA = "0x180CBF490", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600128A")]
			[Address(RVA = "0xCBF9A0", Offset = "0xCBEDA0", VA = "0x180CBF9A0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CharacteristicsDetails other)
			{
			}

			[Token(Token = "0x600128B")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600128C")]
			[Address(RVA = "0xCBFCE0", Offset = "0xCBF0E0", VA = "0x180CBFCE0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacteristicsInfo> _parser;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000623")]
	public const int CharacteristicDetailsByIdFieldNumber = 1;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, Types.CharacteristicsDetails>.Codec _map_characteristicDetailsById_codec;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x18")]
	private readonly MapField<int, Types.CharacteristicsDetails> characteristicDetailsById_;

	[Token(Token = "0x170003ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacteristicsInfo> Parser
	{
		[Token(Token = "0x600125D")]
		[Address(RVA = "0xCC0790", Offset = "0xCBFB90", VA = "0x180CC0790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600125E")]
		[Address(RVA = "0xCC06E0", Offset = "0xCBFAE0", VA = "0x180CC06E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600125F")]
		[Address(RVA = "0xCC09A0", Offset = "0xCBFDA0", VA = "0x180CC09A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, Types.CharacteristicsDetails> CharacteristicDetailsById
	{
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001260")]
	[Address(RVA = "0xCC0660", Offset = "0xCBFA60", VA = "0x180CC0660")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacteristicsInfo()
	{
	}

	[Token(Token = "0x6001261")]
	[Address(RVA = "0xCC05D0", Offset = "0xCBF9D0", VA = "0x180CC05D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacteristicsInfo(CharacteristicsInfo other)
	{
	}

	[Token(Token = "0x6001262")]
	[Address(RVA = "0xCC00B0", Offset = "0xCBF4B0", VA = "0x180CC00B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacteristicsInfo Clone()
	{
		return null;
	}

	[Token(Token = "0x6001264")]
	[Address(RVA = "0xCC0170", Offset = "0xCBF570", VA = "0x180CC0170", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0xCC0250", Offset = "0xCBF650", VA = "0x180CC0250", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacteristicsInfo other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001267")]
	[Address(RVA = "0xCC0360", Offset = "0xCBF760", VA = "0x180CC0360", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001268")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001269")]
	[Address(RVA = "0xCC08F0", Offset = "0xCBFCF0", VA = "0x180CC08F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600126A")]
	[Address(RVA = "0xCC0010", Offset = "0xCBF410", VA = "0x180CC0010", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600126B")]
	[Address(RVA = "0xCC02E0", Offset = "0xCBF6E0", VA = "0x180CC02E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacteristicsInfo other)
	{
	}

	[Token(Token = "0x600126C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0xCC07E0", Offset = "0xCBFBE0", VA = "0x180CC07E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
