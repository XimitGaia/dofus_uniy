using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x2000802")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactLevelUpEvent : IMessage<ContactLevelUpEvent>, IMessage, IEquatable<ContactLevelUpEvent>, IDeepCloneable<ContactLevelUpEvent>, IBufferMessage
{
	[Token(Token = "0x4001B94")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactLevelUpEvent> _parser;

	[Token(Token = "0x4001B95")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B96")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4001B97")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4001B98")]
	public const int CharacterIdFieldNumber = 2;

	[Token(Token = "0x4001B99")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x4001B9A")]
	public const int LevelFieldNumber = 3;

	[Token(Token = "0x4001B9B")]
	[FieldOffset(Offset = "0x28")]
	private int level_;

	[Token(Token = "0x1700120C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContactLevelUpEvent> Parser
	{
		[Token(Token = "0x60054EB")]
		[Address(RVA = "0xAEA010", Offset = "0xAE9410", VA = "0x180AEA010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60054EC")]
		[Address(RVA = "0xAE9F60", Offset = "0xAE9360", VA = "0x180AE9F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60054ED")]
		[Address(RVA = "0xAEA200", Offset = "0xAE9600", VA = "0x180AEA200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0xAEA2E0", Offset = "0xAE96E0", VA = "0x180AEA2E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001210")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001211")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60054EE")]
	[Address(RVA = "0xAE9F10", Offset = "0xAE9310", VA = "0x180AE9F10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactLevelUpEvent()
	{
	}

	[Token(Token = "0x60054EF")]
	[Address(RVA = "0xAE9E60", Offset = "0xAE9260", VA = "0x180AE9E60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLevelUpEvent(ContactLevelUpEvent other)
	{
	}

	[Token(Token = "0x60054F0")]
	[Address(RVA = "0xAE99B0", Offset = "0xAE8DB0", VA = "0x180AE99B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLevelUpEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60054F7")]
	[Address(RVA = "0xAE9A90", Offset = "0xAE8E90", VA = "0x180AE9A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054F8")]
	[Address(RVA = "0xAE9B50", Offset = "0xAE8F50", VA = "0x180AE9B50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactLevelUpEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054F9")]
	[Address(RVA = "0xAE9BD0", Offset = "0xAE8FD0", VA = "0x180AE9BD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60054FA")]
	[Address(RVA = "0xAE9D00", Offset = "0xAE9100", VA = "0x180AE9D00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60054FB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60054FC")]
	[Address(RVA = "0xAEA150", Offset = "0xAE9550", VA = "0x180AEA150", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60054FD")]
	[Address(RVA = "0xAE98C0", Offset = "0xAE8CC0", VA = "0x180AE98C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60054FE")]
	[Address(RVA = "0xAE9C80", Offset = "0xAE9080", VA = "0x180AE9C80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContactLevelUpEvent other)
	{
	}

	[Token(Token = "0x60054FF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005500")]
	[Address(RVA = "0xAEA060", Offset = "0xAE9460", VA = "0x180AEA060", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
