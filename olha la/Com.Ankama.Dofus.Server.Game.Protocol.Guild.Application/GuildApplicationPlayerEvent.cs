using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x2000506")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationPlayerEvent : IMessage<GuildApplicationPlayerEvent>, IMessage, IEquatable<GuildApplicationPlayerEvent>, IDeepCloneable<GuildApplicationPlayerEvent>, IBufferMessage
{
	[Token(Token = "0x2000507")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000508")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ApplicationInformation : IMessage<ApplicationInformation>, IMessage, IEquatable<ApplicationInformation>, IDeepCloneable<ApplicationInformation>, IBufferMessage
		{
			[Token(Token = "0x400111D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ApplicationInformation> _parser;

			[Token(Token = "0x400111E")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400111F")]
			public const int GuildInformationFieldNumber = 1;

			[Token(Token = "0x4001120")]
			[FieldOffset(Offset = "0x18")]
			private GuildInformation guildInformation_;

			[Token(Token = "0x4001121")]
			public const int ApplyFieldNumber = 2;

			[Token(Token = "0x4001122")]
			[FieldOffset(Offset = "0x20")]
			private SocialApplicationInformation apply_;

			[Token(Token = "0x17000B49")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ApplicationInformation> Parser
			{
				[Token(Token = "0x6003538")]
				[Address(RVA = "0x9E1D10", Offset = "0x9E1110", VA = "0x1809E1D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B4A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003539")]
				[Address(RVA = "0x9E1C90", Offset = "0x9E1090", VA = "0x1809E1C90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B4B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600353A")]
				[Address(RVA = "0x9E1EB0", Offset = "0x9E12B0", VA = "0x1809E1EB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B4C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public GuildInformation GuildInformation
			{
				[Token(Token = "0x600353E")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x600353F")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17000B4D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SocialApplicationInformation Apply
			{
				[Token(Token = "0x6003540")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003541")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x600353B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ApplicationInformation()
			{
			}

			[Token(Token = "0x600353C")]
			[Address(RVA = "0x9E1BF0", Offset = "0x9E0FF0", VA = "0x1809E1BF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ApplicationInformation(ApplicationInformation other)
			{
			}

			[Token(Token = "0x600353D")]
			[Address(RVA = "0x9E17D0", Offset = "0x9E0BD0", VA = "0x1809E17D0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ApplicationInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6003542")]
			[Address(RVA = "0x9E18A0", Offset = "0x9E0CA0", VA = "0x1809E18A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003543")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ApplicationInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003544")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003545")]
			[Address(RVA = "0x9E1A90", Offset = "0x9E0E90", VA = "0x1809E1A90", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003546")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003547")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003548")]
			[Address(RVA = "0x9E1710", Offset = "0x9E0B10", VA = "0x1809E1710", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003549")]
			[Address(RVA = "0x9E1960", Offset = "0x9E0D60", VA = "0x1809E1960", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ApplicationInformation other)
			{
			}

			[Token(Token = "0x600354A")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600354B")]
			[Address(RVA = "0x9E1D60", Offset = "0x9E1160", VA = "0x1809E1D60", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationPlayerEvent> _parser;

	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400111B")]
	public const int ApplicationFieldNumber = 1;

	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x18")]
	private Types.ApplicationInformation application_;

	[Token(Token = "0x17000B45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationPlayerEvent> Parser
	{
		[Token(Token = "0x6003525")]
		[Address(RVA = "0x9E4990", Offset = "0x9E3D90", VA = "0x1809E4990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B46")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003526")]
		[Address(RVA = "0x9E48E0", Offset = "0x9E3CE0", VA = "0x1809E48E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003527")]
		[Address(RVA = "0x9E4AE0", Offset = "0x9E3EE0", VA = "0x1809E4AE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ApplicationInformation Application
	{
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6003528")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationPlayerEvent()
	{
	}

	[Token(Token = "0x6003529")]
	[Address(RVA = "0x9E47A0", Offset = "0x9E3BA0", VA = "0x1809E47A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationPlayerEvent(GuildApplicationPlayerEvent other)
	{
	}

	[Token(Token = "0x600352A")]
	[Address(RVA = "0x9E4260", Offset = "0x9E3660", VA = "0x1809E4260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationPlayerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600352D")]
	[Address(RVA = "0x9E43C0", Offset = "0x9E37C0", VA = "0x1809E43C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600352E")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationPlayerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600352F")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003530")]
	[Address(RVA = "0x9E4640", Offset = "0x9E3A40", VA = "0x1809E4640", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003531")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003532")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003533")]
	[Address(RVA = "0x9E41D0", Offset = "0x9E35D0", VA = "0x1809E41D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003534")]
	[Address(RVA = "0x9E4470", Offset = "0x9E3870", VA = "0x1809E4470", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationPlayerEvent other)
	{
	}

	[Token(Token = "0x6003535")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003536")]
	[Address(RVA = "0x9E49E0", Offset = "0x9E3DE0", VA = "0x1809E49E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
