using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x2000854")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatChannelMessageEvent : IMessage<ChatChannelMessageEvent>, IMessage, IEquatable<ChatChannelMessageEvent>, IDeepCloneable<ChatChannelMessageEvent>, IBufferMessage
{
	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatChannelMessageEvent> _parser;

	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4001CCC")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x20")]
	private string content_;

	[Token(Token = "0x4001CCE")]
	public const int ChannelFieldNumber = 2;

	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x28")]
	private Channel channel_;

	[Token(Token = "0x4001CD0")]
	public const int DateFieldNumber = 3;

	[Token(Token = "0x4001CD1")]
	[FieldOffset(Offset = "0x30")]
	private string date_;

	[Token(Token = "0x4001CD2")]
	public const int SenderCharacterIdFieldNumber = 4;

	[Token(Token = "0x4001CD3")]
	[FieldOffset(Offset = "0x38")]
	private long senderCharacterId_;

	[Token(Token = "0x4001CD4")]
	public const int SenderAccountIdFieldNumber = 5;

	[Token(Token = "0x4001CD5")]
	[FieldOffset(Offset = "0x40")]
	private long senderAccountId_;

	[Token(Token = "0x4001CD6")]
	public const int SenderPrefixFieldNumber = 6;

	[Token(Token = "0x4001CD7")]
	[FieldOffset(Offset = "0x48")]
	private string senderPrefix_;

	[Token(Token = "0x4001CD8")]
	public const int SenderNameFieldNumber = 7;

	[Token(Token = "0x4001CD9")]
	[FieldOffset(Offset = "0x50")]
	private string senderName_;

	[Token(Token = "0x4001CDA")]
	public const int FromAdminFieldNumber = 8;

	[Token(Token = "0x4001CDB")]
	[FieldOffset(Offset = "0x58")]
	private bool fromAdmin_;

	[Token(Token = "0x4001CDC")]
	public const int ObjectFieldNumber = 9;

	[Token(Token = "0x4001CDD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

	[Token(Token = "0x4001CDE")]
	[FieldOffset(Offset = "0x60")]
	private readonly RepeatedField<ObjectItemInventory> object_;

	[Token(Token = "0x4001CDF")]
	public const int OriginServerIdFieldNumber = 10;

	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int OriginServerIdDefaultValue;

	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0x68")]
	private int originServerId_;

	[Token(Token = "0x170012D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChatChannelMessageEvent> Parser
	{
		[Token(Token = "0x600587A")]
		[Address(RVA = "0xAFE990", Offset = "0xAFDD90", VA = "0x180AFE990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600587B")]
		[Address(RVA = "0xAFE870", Offset = "0xAFDC70", VA = "0x180AFE870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600587C")]
		[Address(RVA = "0xAFEF00", Offset = "0xAFE300", VA = "0x180AFEF00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x6005880")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005881")]
		[Address(RVA = "0xAFEFE0", Offset = "0xAFE3E0", VA = "0x180AFEFE0")]
		set
		{
		}
	}

	[Token(Token = "0x170012D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Channel Channel
	{
		[Token(Token = "0x6005882")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Channel);
		}
		[Token(Token = "0x6005883")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170012DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Date
	{
		[Token(Token = "0x6005884")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005885")]
		[Address(RVA = "0xAFF050", Offset = "0xAFE450", VA = "0x180AFF050")]
		set
		{
		}
	}

	[Token(Token = "0x170012DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SenderCharacterId
	{
		[Token(Token = "0x6005886")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005887")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x170012DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SenderAccountId
	{
		[Token(Token = "0x6005888")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005889")]
		[Address(RVA = "0xAFF0D0", Offset = "0xAFE4D0", VA = "0x180AFF0D0")]
		set
		{
		}
	}

	[Token(Token = "0x170012DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SenderPrefix
	{
		[Token(Token = "0x600588A")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600588B")]
		[Address(RVA = "0xAFF150", Offset = "0xAFE550", VA = "0x180AFF150")]
		set
		{
		}
	}

	[Token(Token = "0x170012DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SenderName
	{
		[Token(Token = "0x600588C")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600588D")]
		[Address(RVA = "0xAFF0E0", Offset = "0xAFE4E0", VA = "0x180AFF0E0")]
		set
		{
		}
	}

	[Token(Token = "0x170012DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool FromAdmin
	{
		[Token(Token = "0x600588E")]
		[Address(RVA = "0x874E60", Offset = "0x874260", VA = "0x180874E60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600588F")]
		[Address(RVA = "0x874F50", Offset = "0x874350", VA = "0x180874F50")]
		set
		{
		}
	}

	[Token(Token = "0x170012E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Object
	{
		[Token(Token = "0x6005890")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OriginServerId
	{
		[Token(Token = "0x6005891")]
		[Address(RVA = "0xAFE920", Offset = "0xAFDD20", VA = "0x180AFE920")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005892")]
		[Address(RVA = "0xAFF0C0", Offset = "0xAFE4C0", VA = "0x180AFF0C0")]
		set
		{
		}
	}

	[Token(Token = "0x170012E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOriginServerId
	{
		[Token(Token = "0x6005893")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600587D")]
	[Address(RVA = "0xAFE780", Offset = "0xAFDB80", VA = "0x180AFE780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelMessageEvent()
	{
	}

	[Token(Token = "0x600587E")]
	[Address(RVA = "0xAFE680", Offset = "0xAFDA80", VA = "0x180AFE680")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelMessageEvent(ChatChannelMessageEvent other)
	{
	}

	[Token(Token = "0x600587F")]
	[Address(RVA = "0xAFDCF0", Offset = "0xAFD0F0", VA = "0x180AFDCF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelMessageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005894")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOriginServerId()
	{
	}

	[Token(Token = "0x6005895")]
	[Address(RVA = "0xAFDE20", Offset = "0xAFD220", VA = "0x180AFDE20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005896")]
	[Address(RVA = "0xAFDFB0", Offset = "0xAFD3B0", VA = "0x180AFDFB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatChannelMessageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005897")]
	[Address(RVA = "0xAFE100", Offset = "0xAFD500", VA = "0x180AFE100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005898")]
	[Address(RVA = "0xAFE460", Offset = "0xAFD860", VA = "0x180AFE460", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005899")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600589A")]
	[Address(RVA = "0xAFEC90", Offset = "0xAFE090", VA = "0x180AFEC90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600589B")]
	[Address(RVA = "0xAFDA50", Offset = "0xAFCE50", VA = "0x180AFDA50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600589C")]
	[Address(RVA = "0xAFE320", Offset = "0xAFD720", VA = "0x180AFE320", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChatChannelMessageEvent other)
	{
	}

	[Token(Token = "0x600589D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600589E")]
	[Address(RVA = "0xAFE9E0", Offset = "0xAFDDE0", VA = "0x180AFE9E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
