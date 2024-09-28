using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009CD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyEntity : IMessage<PartyEntity>, IMessage, IEquatable<PartyEntity>, IDeepCloneable<PartyEntity>, IBufferMessage
{
	[Token(Token = "0x20009CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009CF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class EntityMember : IMessage<EntityMember>, IMessage, IEquatable<EntityMember>, IDeepCloneable<EntityMember>, IBufferMessage
		{
			[Token(Token = "0x40022BD")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<EntityMember> _parser;

			[Token(Token = "0x40022BE")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40022BF")]
			public const int InitiativeFieldNumber = 1;

			[Token(Token = "0x40022C0")]
			[FieldOffset(Offset = "0x18")]
			private int initiative_;

			[Token(Token = "0x40022C1")]
			public const int CommonsInformationFieldNumber = 2;

			[Token(Token = "0x40022C2")]
			[FieldOffset(Offset = "0x20")]
			private PartyUpdateCommonsInformation commonsInformation_;

			[Token(Token = "0x170015E1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<EntityMember> Parser
			{
				[Token(Token = "0x6006623")]
				[Address(RVA = "0xBAA7A0", Offset = "0xBA9BA0", VA = "0x180BAA7A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015E2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006624")]
				[Address(RVA = "0xBAA720", Offset = "0xBA9B20", VA = "0x180BAA720")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015E3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006625")]
				[Address(RVA = "0xBAA910", Offset = "0xBA9D10", VA = "0x180BAA910", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015E4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Initiative
			{
				[Token(Token = "0x6006629")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600662A")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170015E5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PartyUpdateCommonsInformation CommonsInformation
			{
				[Token(Token = "0x600662B")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x600662C")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6006626")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EntityMember()
			{
			}

			[Token(Token = "0x6006627")]
			[Address(RVA = "0xBAA630", Offset = "0xBA9A30", VA = "0x180BAA630")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EntityMember(EntityMember other)
			{
			}

			[Token(Token = "0x6006628")]
			[Address(RVA = "0xBAA1E0", Offset = "0xBA95E0", VA = "0x180BAA1E0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public EntityMember Clone()
			{
				return null;
			}

			[Token(Token = "0x600662D")]
			[Address(RVA = "0xBAA300", Offset = "0xBA9700", VA = "0x180BAA300", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600662E")]
			[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(EntityMember other)
			{
				return default(bool);
			}

			[Token(Token = "0x600662F")]
			[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006630")]
			[Address(RVA = "0xBAA4D0", Offset = "0xBA98D0", VA = "0x180BAA4D0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006631")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006632")]
			[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006633")]
			[Address(RVA = "0xBAA120", Offset = "0xBA9520", VA = "0x180BAA120", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006634")]
			[Address(RVA = "0xBAA3B0", Offset = "0xBA97B0", VA = "0x180BAA3B0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(EntityMember other)
			{
			}

			[Token(Token = "0x6006635")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006636")]
			[Address(RVA = "0xBAA7F0", Offset = "0xBA9BF0", VA = "0x180BAA7F0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40022B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyEntity> _parser;

	[Token(Token = "0x40022B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022B5")]
	public const int IndexIdFieldNumber = 1;

	[Token(Token = "0x40022B6")]
	[FieldOffset(Offset = "0x18")]
	private int indexId_;

	[Token(Token = "0x40022B7")]
	public const int EntityModelIdFieldNumber = 2;

	[Token(Token = "0x40022B8")]
	[FieldOffset(Offset = "0x1C")]
	private int entityModelId_;

	[Token(Token = "0x40022B9")]
	public const int LookFieldNumber = 3;

	[Token(Token = "0x40022BA")]
	[FieldOffset(Offset = "0x20")]
	private EntityLook look_;

	[Token(Token = "0x40022BB")]
	public const int EntityMemberFieldNumber = 4;

	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0x28")]
	private Types.EntityMember entityMember_;

	[Token(Token = "0x170015DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyEntity> Parser
	{
		[Token(Token = "0x600660A")]
		[Address(RVA = "0xBAD500", Offset = "0xBAC900", VA = "0x180BAD500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600660B")]
		[Address(RVA = "0xBAD450", Offset = "0xBAC850", VA = "0x180BAD450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600660C")]
		[Address(RVA = "0xBAD7A0", Offset = "0xBACBA0", VA = "0x180BAD7A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IndexId
	{
		[Token(Token = "0x6006610")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006611")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170015DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EntityModelId
	{
		[Token(Token = "0x6006612")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006613")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170015DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook Look
	{
		[Token(Token = "0x6006614")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006615")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x170015E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.EntityMember EntityMember
	{
		[Token(Token = "0x6006616")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006617")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x600660D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyEntity()
	{
	}

	[Token(Token = "0x600660E")]
	[Address(RVA = "0xBAD2B0", Offset = "0xBAC6B0", VA = "0x180BAD2B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyEntity(PartyEntity other)
	{
	}

	[Token(Token = "0x600660F")]
	[Address(RVA = "0xBACC90", Offset = "0xBAC090", VA = "0x180BACC90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyEntity Clone()
	{
		return null;
	}

	[Token(Token = "0x6006618")]
	[Address(RVA = "0xBACCF0", Offset = "0xBAC0F0", VA = "0x180BACCF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006619")]
	[Address(RVA = "0xBACDC0", Offset = "0xBAC1C0", VA = "0x180BACDC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyEntity other)
	{
		return default(bool);
	}

	[Token(Token = "0x600661A")]
	[Address(RVA = "0xBACE50", Offset = "0xBAC250", VA = "0x180BACE50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600661B")]
	[Address(RVA = "0xBAD150", Offset = "0xBAC550", VA = "0x180BAD150", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600661C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600661D")]
	[Address(RVA = "0xBAD6E0", Offset = "0xBACAE0", VA = "0x180BAD6E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600661E")]
	[Address(RVA = "0xBACB80", Offset = "0xBABF80", VA = "0x180BACB80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600661F")]
	[Address(RVA = "0xBACF20", Offset = "0xBAC320", VA = "0x180BACF20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyEntity other)
	{
	}

	[Token(Token = "0x6006620")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006621")]
	[Address(RVA = "0xBAD550", Offset = "0xBAC950", VA = "0x180BAD550", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
