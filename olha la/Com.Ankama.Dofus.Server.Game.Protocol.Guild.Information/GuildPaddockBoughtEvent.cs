using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004BE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildPaddockBoughtEvent : IMessage<GuildPaddockBoughtEvent>, IMessage, IEquatable<GuildPaddockBoughtEvent>, IDeepCloneable<GuildPaddockBoughtEvent>, IBufferMessage
{
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildPaddockBoughtEvent> _parser;

	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001041")]
	public const int PaddockFieldNumber = 1;

	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x18")]
	private PaddockInformation paddock_;

	[Token(Token = "0x17000AA6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildPaddockBoughtEvent> Parser
	{
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x9F6150", Offset = "0x9F5550", VA = "0x1809F6150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x9F60A0", Offset = "0x9F54A0", VA = "0x1809F60A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x9F62A0", Offset = "0x9F56A0", VA = "0x1809F62A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockInformation Paddock
	{
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockBoughtEvent()
	{
	}

	[Token(Token = "0x6003214")]
	[Address(RVA = "0x9F6030", Offset = "0x9F5430", VA = "0x1809F6030")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockBoughtEvent(GuildPaddockBoughtEvent other)
	{
	}

	[Token(Token = "0x6003215")]
	[Address(RVA = "0x9F5CB0", Offset = "0x9F50B0", VA = "0x1809F5CB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildPaddockBoughtEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003218")]
	[Address(RVA = "0x9F5D50", Offset = "0x9F5150", VA = "0x1809F5D50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003219")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildPaddockBoughtEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600321A")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600321B")]
	[Address(RVA = "0x9F5ED0", Offset = "0x9F52D0", VA = "0x1809F5ED0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600321C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600321D")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600321E")]
	[Address(RVA = "0x9F5C20", Offset = "0x9F5020", VA = "0x1809F5C20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600321F")]
	[Address(RVA = "0x9F5E00", Offset = "0x9F5200", VA = "0x1809F5E00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildPaddockBoughtEvent other)
	{
	}

	[Token(Token = "0x6003220")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003221")]
	[Address(RVA = "0x9F61A0", Offset = "0x9F55A0", VA = "0x1809F61A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
